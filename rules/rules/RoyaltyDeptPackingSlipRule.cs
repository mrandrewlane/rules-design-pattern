using System;
using System.Collections.Generic;
using System.Text;

namespace rules.rules
{
    class RoyaltyDeptPackingSlipRule : IRule
    {
        public string Execute(Context ctx)
        {
            if (ctx.isBook) return "create a duplicate packing slip for the royalty department";

            return "not book";
        }

        public bool IsApplicable(Context ctx)
        {
            return true;
        }
    }
}
