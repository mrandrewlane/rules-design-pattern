using System;
using System.Collections.Generic;
using System.Text;

namespace rules.rules
{
    class ShippingPackingSlipRule : IRule
    {
        public string Execute(Context ctx)
        {
            if (ctx.isPhysicalProduct) return "generate a packing slip for shipping";

            return "not physical product";
        }

        public bool IsApplicable(Context ctx)
        {
            return true;
        }
    }
}
