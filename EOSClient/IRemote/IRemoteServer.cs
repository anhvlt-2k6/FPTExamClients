using QuestionLib;

namespace IRemote
{
    // Token: 0x02000007 RID: 7
    public interface IRemoteServer
    {
        // Token: 0x0600000E RID: 14
        EOSData ConductExam(RegisterData rd);

        // Token: 0x0600000F RID: 15
        SubmitStatus Submit(SubmitPaper submitPaper, ref string msg);

        // Token: 0x06000010 RID: 16
        byte[] GetImageIDData(string imageName);

        // Token: 0x06000011 RID: 17
        byte[] GetImageData(string imageName);

        // Token: 0x06000012 RID: 18
        void SaveCaptureImage(byte[] img, string examCode, string login);

        // Token: 0x06000013 RID: 19
        void UploadImage(string examcode, string studentcode, string base64Image);
    }
}
