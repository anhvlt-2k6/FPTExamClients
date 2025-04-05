using EncryptData;
using GradeLib;
using IRemote;
using System;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace PEALogin
{
    // Token: 0x02000002 RID: 2
    public partial class AuthenticateForm : Form
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public AuthenticateForm()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000004 RID: 4 RVA: 0x000028AC File Offset: 0x00000AAC
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool flag = this.txtTestName.Text.Trim().Equals("");
            if (flag)
            {
                MessageBox.Show("Please provide a [Test name]", "Exam Registering");
            }
            else
            {
                bool flag2 = this.txtUser.Text.Trim().Equals("");
                if (flag2)
                {
                    MessageBox.Show("Please provide an [User name]", "Exam Registering");
                }
                else
                {
                    bool flag3 = this.txtPassword.Text.Trim().Equals("");
                    if (flag3)
                    {
                        MessageBox.Show("Please provide a [Password]", "Exam Registering");
                    }
                    else
                    {
                        bool flag4 = this.txtDomain.Text.Trim().Equals("");
                        if (flag4)
                        {
                            MessageBox.Show("Please provide a [Domain] address", "Exam Registering");
                        }
                        else
                        {
                            try
                            {
                                string url = string.Concat(new object[]
                                {
                                    "tcp://",
                                    this.si.IP,
                                    ":",
                                    this.si.Port,
                                    "/Server"
                                });
                                IRemoteServer remoteServer = (IRemoteServer)Activator.GetObject(typeof(IRemoteServer), url);
                                this.pd = remoteServer.ConductTest(new RegisterData
                                {
                                    Login = this.txtUser.Text,
                                    Password = this.txtPassword.Text,
                                    TestName = this.txtTestName.Text,
                                    PaperNo = -1,
                                    Machine = Environment.MachineName.ToUpper()
                                });
                                bool flag5 = this.pd.Status == RegisterStatus.TEST_NAME_NOT_EXISTS;
                                if (flag5)
                                {
                                    MessageBox.Show("The test name is not available!", "Exam Registering", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    bool flag6 = this.pd.Status == RegisterStatus.PAPER_NO_NOT_EXISTS;
                                    if (flag6)
                                    {
                                        MessageBox.Show("The [Paper no] does not exists!", "Exam Registering", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    }
                                    else
                                    {
                                        bool flag7 = this.pd.Status == RegisterStatus.FINISHED;
                                        if (flag7)
                                        {
                                            MessageBox.Show("The test is finished!", "Exam Registering", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        }
                                        else
                                        {
                                            bool flag8 = this.pd.Status == RegisterStatus.REGISTERED;
                                            if (flag8)
                                            {
                                                MessageBox.Show("This user [" + this.txtUser.Text + "] is already registered. Need re-assign to continue the exam.", "Exam Registering", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                            }
                                            else
                                            {
                                                bool flag9 = this.pd.Status == RegisterStatus.REGISTER_ERROR;
                                                if (flag9)
                                                {
                                                    MessageBox.Show("Register ERROR, try again", "Exam Registering", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                }
                                                else
                                                {
                                                    bool flag10 = this.pd.Status == RegisterStatus.NOT_ALLOW_STUDENT;
                                                    if (flag10)
                                                    {
                                                        MessageBox.Show("The account is NOT allow to take the exam!", "Exam Registering", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                    }
                                                    else
                                                    {
                                                        bool flag11 = this.pd.Status == RegisterStatus.LOGIN_FAILED;
                                                        if (flag11)
                                                        {
                                                            MessageBox.Show("Sorry, unable to verify your information. Check [User Name] and [Password]!", "Login failed");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                bool flag12 = this.pd.Status == RegisterStatus.NEW || this.pd.Status == RegisterStatus.REASSIGN;
                                if (flag12)
                                {
                                    this.pd.GUI = GZipHelper.DeCompress(this.pd.GUI, this.pd.OriginSize);
                                    Assembly assembly = Assembly.Load(this.pd.GUI);
                                    Type type = assembly.GetType("PEAClient.FrmPEAClient");
                                    Form form = (Form)Activator.CreateInstance(type);
                                    IExamclient examclient = (IExamclient)form;
                                    this.pd.GUI = null;
                                    this.pd.ServerInfomation = this.si;
                                    examclient.SetExamData(this.pd);
                                    examclient.SetAuthenForm(this);
                                    form.Show();
                                    base.Hide();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Login");
                            }
                        }
                    }
                }
            }
        }

        // Token: 0x06000005 RID: 5 RVA: 0x00002C8C File Offset: 0x00000E8C
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Token: 0x06000006 RID: 6 RVA: 0x00002C98 File Offset: 0x00000E98
        private void AuthenticateForm_Load(object sender, EventArgs e)
        {
            bool flag = !this.IsAdministrator();
            if (flag)
            {
                MessageBox.Show("You must login Windows as System Administrator or Run the application as administrator.", "PEA Login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Application.Exit();
            }
            string text = "PEA_Server_Info.dat";
            bool flag2 = File.Exists(Application.StartupPath + "\\" + text);
            if (flag2)
            {
                try
                {
                    string key = "04021976";
                    byte[] arrBytes = EncryptSupport.Decrypt_FromFile(text, key);
                    this.si = (ServerInfo)EncryptSupport.ByteArrayToObject(arrBytes);
                    bool flag3 = !this.version.Equals(this.si.Version);
                    if (flag3)
                    {
                        MessageBox.Show("Wrong PEA client version! Please copy the right PEA client version.", "Version Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        Application.Exit();
                    }
                    this.txtDomain.Text = this.si.Domain;
                }
                catch
                {
                    MessageBox.Show("Wrong [" + text + "] file format! Please copy the right EOS client version.", "Version Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("File [" + text + "] not found! Please copy the right EOS client version.", "Version Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }

        // Token: 0x06000007 RID: 7 RVA: 0x00002DCC File Offset: 0x00000FCC
        private bool IsAdministrator()
        {
            WindowsIdentity current = WindowsIdentity.GetCurrent();
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        // Token: 0x0400000E RID: 14
        private string version = "41750C47-4395-4E5D-AD36-32CE826F5F59";

        // Token: 0x0400000F RID: 15
        private ServerInfo si = null;

        // Token: 0x04000010 RID: 16
        private PEAData pd = null;
    }
}
