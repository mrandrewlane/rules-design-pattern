using System;
using System.Collections.Generic;
using System.Text;

namespace rules.rules
{
    class FreeFirstAidVideoRule : IRule
    {
        public string Execute(Context ctx)
        {
            if (ctx.isVideo && ctx.videoTitle == "Learning to ski") return "add a free \"First Aid\" video to the packing slip";

            return "not video \"Learning to ski\"";
        }

        public bool IsApplicable(Context ctx)
        {
            return true;
        }
    }
}
