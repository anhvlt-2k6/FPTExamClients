namespace IRemote
{
    // Token: 0x02000008 RID: 8
    public interface IRemoteServer
    {
        // Token: 0x0600001B RID: 27
        PEAData ConductTest(RegisterData rd);

        // Token: 0x0600001C RID: 28
        SubmitStatus Submit(SubmitSolution solution, ref string msg);

        // Token: 0x0600001D RID: 29
        bool Log(string examCode, string login, string logStr);
    }
}
