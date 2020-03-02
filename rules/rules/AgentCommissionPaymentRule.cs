using System;
using System.Collections.Generic;
using System.Text;

namespace rules.rules
{
    class AgentCommissionPaymentRule : IRule
    {
        public string Execute(Context ctx)
        {
            if (ctx.isPhysicalProduct || ctx.isBook) return "generate a commission payment to the agent";

            return "not physical product or book";
        }
        public bool IsApplicable(Context ctx)
        {
            return true;
        }
    }
}
