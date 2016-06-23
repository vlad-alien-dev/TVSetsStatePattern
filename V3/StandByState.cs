using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSetsStatePattern.V3
{
    class StandByState : ITvState
    {
        public void ChannelUp(TVset tvSet)
        {
            tvSet.IsSwtchedOn = true;
        }

        public void SoundUp(TVset tvSet)
        {
            
        }
    }
}