namespace IRemote
{
    // Token: 0x02000002 RID: 2
    public interface IRemoteMonitorServer
    {
        // Token: 0x06000001 RID: 1
        int SaveScreenImage(byte[] img, int index, string examCode, string login);
    }
}
