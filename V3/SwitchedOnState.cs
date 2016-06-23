using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSetsStatePattern.V3
{
    class SwitchedOnState : ITvState
    {
        public void ChannelUp(TVset tvSet)
        {
            tvSet.Channel++;
            Console.WriteLine("You are watching channel {0}", tvSet.Channel);
        }

        public void SoundUp(TVset tvSet)
        {
            tvSet.Sound++;
            Console.WriteLine("The sound level is {0}", tvSet.Sound);
        }

        public void Toggle(TVset tvSet)
        {
            tvSet.TvState = new StandByState();
            Console.WriteLine("The tv is now OFF");
        }
    }
}
