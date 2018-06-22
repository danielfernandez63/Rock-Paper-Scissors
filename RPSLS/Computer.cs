using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {

        public Computer(string name)

        {

            this.name = name;

        }
                //this will create a random roll for one of my six variables aka pc picks

        public override void ChooseGesture()

        {

            Random rnd = new Random();

            choice = rnd.Next(0, 4);

        }


    }
}
