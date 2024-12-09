using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    internal class CommandSpaceClass : ICommand
    {


        public void Run()
        {
            Points += PointsPerClick;
        }
    }
}
