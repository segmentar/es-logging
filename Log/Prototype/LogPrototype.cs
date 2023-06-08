using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLog
    {
        public SLLog(Boolean debug)
        {
            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
