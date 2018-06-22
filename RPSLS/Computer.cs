using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Players
    {

        public Computer(string name)

        {

            this.name = name;

        }

        public override void ChooseGesture()

        {

            Random rnd = new Random();

            choice = rnd.Next(0, 5);

        }


    }
}
