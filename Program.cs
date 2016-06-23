using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TVSetsStatePattern.V1;
using TVSetsStatePattern.V4;

namespace TVSetsStatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //TVset tv = new TVset();
            //tv.ChannelUp();
            //tv.SoundUp();

            TVset tv = new TVset(new SwitchedOnState());

            tv.ChannelUp();

            tv.ChannelUp();

            tv.SoundUp();

            tv.Toggle();

            tv.SoundUp();

            tv.ChannelUp();

            Console.ReadKey();
        }
    }
}
