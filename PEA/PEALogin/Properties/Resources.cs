using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace PEALogin.Properties
{
    // Token: 0x02000004 RID: 4
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {
        // Token: 0x06000009 RID: 9 RVA: 0x00002E1A File Offset: 0x0000101A
        internal Resources()
        {
        }

        // Token: 0x17000001 RID: 1
        // (get) Token: 0x0600000A RID: 10 RVA: 0x00002E24 File Offset: 0x00001024
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                bool flag = Resources.resourceMan == null;
                if (flag)
                {
                    ResourceManager resourceManager = new ResourceManager("PEALogin.Properties.Resources", typeof(Resources).Assembly);
                    Resources.resourceMan = resourceManager;
                }
                return Resources.resourceMan;
            }
        }

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x0600000B RID: 11 RVA: 0x00002E6C File Offset: 0x0000106C
        // (set) Token: 0x0600000C RID: 12 RVA: 0x00002E83 File Offset: 0x00001083
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

        // Token: 0x04000011 RID: 17
        private static ResourceManager resourceMan;

        // Token: 0x04000012 RID: 18
        private static CultureInfo resourceCulture;
    }
}
