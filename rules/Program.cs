using System;
using rules.rules;

namespace rules
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Context() { 
                isPhysicalProduct = true,
                isBook = true,
                isVideo = false,
                videoTitle = "",
                isActivateMembership = false,
                isUpgradeMembership = false
            };

            var rules = new IRule[] {
                new ShippingPackingSlipRule(),
                new RoyaltyDeptPackingSlipRule(),
                new ActivateMembershipRule(),
                new UpgradeMembershipRule(),
                new EmailOwnerRule(),
                new FreeFirstAidVideoRule(),
                new AgentCommissionPaymentRule()
            };
            new RuleEvaluator(rules).Execute(ctx);

        }
    }
}
