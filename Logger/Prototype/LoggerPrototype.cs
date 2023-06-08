using Core;

namespace Core.Shared
{
    using System;

    public partial class SLLogger
    {
        public SLLogger(Boolean debug)
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
