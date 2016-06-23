using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSetsStatePattern.V4
{
    class StandByState : ITvState
    {
        public void ChannelUp(TVset tvSet)
        {
            tvSet.TvState = new SwitchedOnState();
        }

        public void SoundUp(TVset tvSet)
        {
            
        }

        public void Toggle(TVset tvSet)
        {
            tvSet.TvState = new SwitchedOnState();
        }
    }
}