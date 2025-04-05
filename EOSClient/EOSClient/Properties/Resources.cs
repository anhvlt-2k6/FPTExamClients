using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace EOSClient.Properties
{
    // Token: 0x02000006 RID: 6
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {
        // Token: 0x0600001B RID: 27 RVA: 0x00003AA8 File Offset: 0x00001CA8
        internal Resources()
        {
        }

        // Token: 0x17000001 RID: 1
        // (get) Token: 0x0600001C RID: 28 RVA: 0x00003AB4 File Offset: 0x00001CB4
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                bool flag = Resources.resourceMan == null;
                if (flag)
                {
                    ResourceManager temp = new ResourceManager("EOSClient.Properties.Resources", typeof(Resources).Assembly);
                    Resources.resourceMan = temp;
                }
                return Resources.resourceMan;
            }
        }

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x0600001D RID: 29 RVA: 0x00003AFC File Offset: 0x00001CFC
        // (set) Token: 0x0600001E RID: 30 RVA: 0x00003B13 File Offset: 0x00001D13
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return Resources.resourceCulture;
            }
            set
            {
                Resources.resourceCulture = value;
            }
        }

        // Token: 0x0400001C RID: 28
        private static ResourceManager resourceMan;

        // Token: 0x0400001D RID: 29
        private static CultureInfo resourceCulture;
    }
}
