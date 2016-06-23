using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSetsStatePattern.V2
{
   public class TVset
    {
        
        public int Sound { get; set; }
        public int Channel { get; set; }


        public ITvState TvState { get; set; }

        public TVset(ITvState tvState)
        {
            TvState = tvState;
        }

        public void SoundUp()
        {
            TvState.SoundUp(this);
        }
    }
}
