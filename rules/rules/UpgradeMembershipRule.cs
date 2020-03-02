using System;
using System.Collections.Generic;
using System.Text;

namespace rules.rules
{
    class UpgradeMembershipRule : IRule
    {
        public string Execute(Context ctx)
        {
            if (ctx.isUpgradeMembership) return "apply the upgrade";

            return "not upgrade";
        }

        public bool IsApplicable(Context ctx)
        {
            return true;
        }
    }
}
