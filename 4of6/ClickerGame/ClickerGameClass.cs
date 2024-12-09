using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    internal class ClickerGameClass
    {
        public int Points {  get; private set; }
        public int PointsPerClick { get; private set; }

        public int PointsPerClickIncrease { get; private set; }

        public ClickerGameClass(int points, int pointsPerClick, int pointsPerClickIncrease)
        {
            Points = points;
            PointsPerClick = pointsPerClick;
            PointsPerClickIncrease = pointsPerClickIncrease;
        }


        public void CommandX()
        {
            Environment.Exit(0);
        }
        public void CommandSpace()
        {
            Points += PointsPerClick;
        }

        public void CommandK()
        {
            if (Points >= 10)
            {
                Points -= 10;
                PointsPerClick += PointsPerClickIncrease;
            }    
        }

        public void CommandS() 
        {
            if(Points >= 100)
            {
                Points -= 100;
                PointsPerClickIncrease++;
            }
            
        }
    }
}
