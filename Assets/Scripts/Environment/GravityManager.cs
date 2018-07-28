using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CelesteEngine.Environment
{
    public static class GravityManager
    {
        private static bool gravityEnabled = true;
        public static bool GravityEnabled
        {
            get { return gravityEnabled; }
            set
            {
                gravityEnabled = value;

                if (GravityEnabledChanged != null)
                {
                    GravityEnabledChanged(gravityEnabled);
                }
            }
        }

        public static Action<bool> GravityEnabledChanged;
    }
}
