using System;
using System.Collections.Generic;
using System.Text;

namespace rules.rules
{
    class EmailOwnerRule : IRule
    {
        public string Execute(Context ctx)
        {
            if (ctx.isActivateMembership || ctx.isUpgradeMembership) return "e-mail the owner and inform them of the activation/upgrade";

            return "not membership or upgrade";
        }
        public bool IsApplicable(Context ctx)
        {
            return true;
        }
    }
}
