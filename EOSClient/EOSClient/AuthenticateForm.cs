using EncryptData;
using IRemote;
using NAudio.Wave;
using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace EOSClient
{
    // Token: 0x02000002 RID: 2
    public partial class AuthenticateForm : Form
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public AuthenticateForm()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000004 RID: 4 RVA: 0x00002ACC File Offset: 0x00000CCC
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool flag = this.txtExamCode.Text.Trim().Equals("");
            if (flag)
            {
                MessageBox.Show("Please provide an Exam code", "Login");
            }
            else
            {
                bool flag2 = this.txtUser.Text.Trim().Equals("");
                if (flag2)
                {
                    MessageBox.Show("Please provide an username", "Login");
                }
                else
                {
                    bool flag3 = this.txtPassword.Text.Trim().Equals("");
                    if (flag3)
                    {
                        MessageBox.Show("Please provide a password", "Login");
                    }
                    else
                    {
                        bool flag4 = this.txtDomain.Text.Trim().Equals("");
                        if (flag4)
                        {
                            MessageBox.Show("Please provide a domain address", "Login");
                        }
                        else
                        {
                            try
                            {
                                bool flag5 = !this.si.Public_IP.Trim().Equals("");
                                if (flag5)
                                {
                                    this.si.IP = this.si.Public_IP;
                                }
                                string remotingURL = string.Concat(new object[]
                                {
                                    "tcp://",
                                    this.si.IP,
                                    ":",
                                    this.si.Port,
                                    "/Server"
                                });
                                IRemoteServer s = (IRemoteServer)Activator.GetObject(typeof(IRemoteServer), remotingURL);
                                RegisterData rd = new RegisterData();
                                rd.Login = this.txtUser.Text;
                                rd.Password = this.txtPassword.Text;
                                rd.ExamCode = this.txtExamCode.Text;
                                rd.Machine = Environment.MachineName.ToUpper();
                                EOSData ed = s.ConductExam(rd);
                                bool flag6 = ed.Status == RegisterStatus.EXAM_CODE_NOT_EXISTS;
                                if (flag6)
                                {
                                    MessageBox.Show("Exam code is not available!", "Start exam", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    bool flag7 = ed.Status == RegisterStatus.FINISHED;
                                    if (flag7)
                                    {
                                        MessageBox.Show("The exam is finished!", "Start exam", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    }
                                    else
                                    {
                                        bool flag8 = ed.Status == RegisterStatus.REGISTERED;
                                        if (flag8)
                                        {
                                            MessageBox.Show("This user [" + this.txtUser.Text + "] is already registered. Need re-assign to continue the exam.", "Exam Registering", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        }
                                        else
                                        {
                                            bool flag9 = ed.Status == RegisterStatus.REGISTER_ERROR;
                                            if (flag9)
                                            {
                                                MessageBox.Show("Register ERROR, try again", "Exam Registering", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }
                                            else
                                            {
                                                bool flag10 = ed.Status == RegisterStatus.NOT_ALLOW_MACHINE;
                                                if (flag10)
                                                {
                                                    MessageBox.Show("Your machine is not allowed to take the exam!", "Exam Registering", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                }
                                                else
                                                {
                                                    bool flag11 = ed.Status == RegisterStatus.NOT_ALLOW_STUDENT;
                                                    if (flag11)
                                                    {
                                                        MessageBox.Show("The account is NOT allowed to take the exam!", "Exam Registering", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                    }
                                                    else
                                                    {
                                                        bool flag12 = ed.Status == RegisterStatus.LOGIN_FAILED;
                                                        if (flag12)
                                                        {
                                                            MessageBox.Show("Sorry, unable to verify your information. Check [User Name] and [Password]!", "Login failed");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                bool flag13 = ed.Status == RegisterStatus.NEW || ed.Status == RegisterStatus.RE_ASSIGN;
                                if (flag13)
                                {
                                    base.Hide();
                                    ed.GUI = AuthenticateForm.DeCompress(ed.GUI, ed.OriginSize);
                                    Assembly a = Assembly.Load(ed.GUI);
                                    Type fType = a.GetType("ExamClient.frmEnglishExamClient");
                                    Form f = (Form)Activator.CreateInstance(fType);
                                    IExamclient iec = (IExamclient)f;
                                    ed.GUI = null;
                                    ed.ServerInfomation = this.si;
                                    ed.RegData = rd;
                                    iec.SetExamData(ed);
                                    f.Show();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                                MessageBox.Show("Start Exam Error:\nCannot connect to the EOS server!\n", "Connecting...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                    }
                }
            }
        }

        // Token: 0x06000005 RID: 5 RVA: 0x00002EA8 File Offset: 0x000010A8
        private static byte[] DeCompress(byte[] bytInput, int originSize)
        {
            Stream s = new GZipStream(new MemoryStream(bytInput), CompressionMode.Decompress);
            byte[] buf = new byte[originSize];
            s.Read(buf, 0, originSize);
            return buf;
        }

        // Token: 0x06000006 RID: 6 RVA: 0x00002ED9 File Offset: 0x000010D9
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Token: 0x06000007 RID: 7 RVA: 0x00002EE4 File Offset: 0x000010E4
        private void AuthenticateForm_Load(object sender, EventArgs e)
        {
            string serverInfoFile = "EOS_Server_Info.dat";
            bool flag = File.Exists(Application.StartupPath + "\\" + serverInfoFile);
            if (flag)
            {
                try
                {
                    string key = "04021976";
                    byte[] buf = EncryptSupport.DecryptQuestions_FromFile(serverInfoFile, key);
                    this.si = (ServerInfo)EncryptSupport.ByteArrayToObject(buf);
                    bool flag2 = !this.version.Equals(this.si.Version);
                    if (flag2)
                    {
                        MessageBox.Show("Wrong EOS client version! Please copy the right EOS client version.", "Version Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        Application.Exit();
                    }
                }
                catch
                {
                    MessageBox.Show("Wrong [" + serverInfoFile + "] file format! Please copy the right EOS client version.", "Version Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("File [" + serverInfoFile + "] not found! Please copy the right EOS client version.", "Version Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }

        // Token: 0x06000008 RID: 8 RVA: 0x00002FD4 File Offset: 0x000011D4
        private bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principle = new WindowsPrincipal(identity);
            return principle.IsInRole(WindowsBuiltInRole.Administrator);
        }

        // Token: 0x06000009 RID: 9 RVA: 0x00003008 File Offset: 0x00001208
        private void linkLBLCheckFont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool flag = this.fcf == null || this.fcf.IsDisposed;
            if (flag)
            {
                this.fcf = new frmCheckFont();
            }
            this.fcf.Show();
        }

        // Token: 0x0600000A RID: 10 RVA: 0x00003048 File Offset: 0x00001248
        private void lblLinkCheckSound_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool flag = !File.Exists("ghosts.mp3");
            if (flag)
            {
                MessageBox.Show("Audio file ghosts.mp3 cannot be found!", "Check sound");
            }
            else
            {
                this.PlayFromUrl("ghosts.mp3");
            }
        }

        // Token: 0x0600000B RID: 11 RVA: 0x00003088 File Offset: 0x00001288
        public void PlayFromUrl(string url)
        {
            FileStream fs = File.OpenRead(url);
            byte[] bufData = new byte[fs.Length];
            fs.Read(bufData, 0, (int)fs.Length);
            fs.Close();
            Stream ms = new MemoryStream(bufData);
            Mp3FileReader reader = new Mp3FileReader(ms);
            WaveOut waveOut = new WaveOut();
            waveOut.Init(reader);
            waveOut.Volume = 1f;
            waveOut.Play();
        }

        // Token: 0x04000011 RID: 17
        private string version = "C3AF3F4B-EA15-4EDA-9750-C0214649FEC8";

        // Token: 0x04000012 RID: 18
        private ServerInfo si = null;

        // Token: 0x04000013 RID: 19
        private frmCheckFont fcf = null;
    }
}
