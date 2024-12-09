using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossTest_Program
{
    public class GameCharacter
    {
        public int Health;
        public int Stamina;
        public int Strength;
        public int initStamina;


        public GameCharacter(int health, int strength, int stamina)
        {
            Health = health;
            Stamina = stamina;
            Strength = strength;
            initStamina = stamina;
        }


        public void Fight(GameCharacter opponent)
        {
            if (Stamina == 0)
            {
                Recharge();
                return;
            }
            opponent.Health -= Strength;
            DrainStamina(10);

        }

        public void Fight(GameCharacter opponent, int strength)
        {
            if (Stamina == 0)
            {
                Recharge();
                return;
            }
            opponent.Health -= strength;
            DrainStamina(10);

        }

        public void DrainStamina(int staminaDrain)
        {
            Stamina -= staminaDrain;
        }

        public void Recharge()
        {
            Stamina += initStamina;
        }
    }
}
