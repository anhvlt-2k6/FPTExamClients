using System.Windows.Forms;

namespace IRemote
{
    // Token: 0x0200000A RID: 10
    public interface IExamclient
    {
        // Token: 0x06000031 RID: 49
        void SetExamData(PEAData peaData);

        // Token: 0x06000032 RID: 50
        void SetAuthenForm(Form f);
    }
}
