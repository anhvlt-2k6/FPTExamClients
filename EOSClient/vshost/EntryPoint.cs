using System.Diagnostics;
using System.Threading;

namespace Microsoft.VisualStudio.HostingProcess
{
    // Token: 0x02000002 RID: 2
    public sealed class EntryPoint
    {
        // Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
        private EntryPoint()
        {
        }

        public static class Synchronize
        {
            public static EventWaitHandle HostingProcessInitialized = new AutoResetEvent(false);
            public static EventWaitHandle StartRunningUsersAssembly = new AutoResetEvent(false);
        }

        // Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
        [DebuggerNonUserCode]
        public static void Main()
        {
            if (Synchronize.HostingProcessInitialized != null)
            {
                Synchronize.HostingProcessInitialized.Set();
                if (Synchronize.StartRunningUsersAssembly != null)
                {
                    Synchronize.StartRunningUsersAssembly.WaitOne();
                }
            }
        }
    }
}
