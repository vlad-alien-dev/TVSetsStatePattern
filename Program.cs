using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSetsStatePattern.V1;

namespace TVSetsStatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TVset tv = new TVset();
            tv.ChannelUp();
            tv.SoundUp();




        }
    }
}
