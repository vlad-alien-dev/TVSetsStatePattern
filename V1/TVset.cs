using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSetsStatePattern.V1
{
    public class TVset
    {
        private bool isSwitchedOn;
        private int channel;
        private int sound;

        public void ChangeChannel()
        {
            if (isSwitchedOn)
            {
                SwitchChannel(channel);
            }
            else
            {
                SwitchOn();
            }
        }

        public void ChangeSound()
        {
            if (isSwitchedOn)
            {
                AlterSound(sound);
            }
        }



        private void SwitchChannel(int channel)
        {
            Console.WriteLine("Current channel is: {0}", channel);
        }

        private void SwitchOn()
        {
            isSwitchedOn = true;
            Console.WriteLine("The TV is now switched on");
        }

        private void AlterSound(int sound)
        {
            Console.WriteLine("Current sound is: {0}", sound);
        }
    }
}
