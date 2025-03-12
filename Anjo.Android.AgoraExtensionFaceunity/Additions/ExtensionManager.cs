using Android.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.Agora.Rte.Extension.Faceunity
{
    public partial class ExtensionManager
    { 
        private static ExtensionManager Instance = null;

        internal ExtensionManager()
        {
            Instance = this;
        }

        public static ExtensionManager GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ExtensionManager();
            }

            return Instance;
        }
    }
}
