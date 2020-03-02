using System;
using System.Collections.Generic;
using System.Text;

namespace rules.rules
{
    class ActivateMembershipRule : IRule
    {
        public string Execute(Context ctx)
        {
            if (ctx.isActivateMembership) return "activate that membership";

            return "not membership";
        }
        public bool IsApplicable(Context ctx)
        {
            return true;
        }
    }
}
