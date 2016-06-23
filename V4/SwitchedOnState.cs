using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSetsStatePattern.V4
{
    class SwitchedOnState : ITvState
    {
        public void ChannelUp(TVset tvSet)
        {
            tvSet.Channel++;
        }

        public void SoundUp(TVset tvSet)
        {
            tvSet.Sound++;
        }

        public void Toggle(TVset tvSet)
        {
            tvSet.TvState = new StandByState();
        }
    }
}
