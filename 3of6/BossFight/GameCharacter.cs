using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class GameCharacter
    {
        private string _name;
        private int _health;
        private int _strength;
        private int _stamina;
        private int _startingStamina;

        public GameCharacter(string name, int health, int strength, int stamina)
        {
            _name = name;
            _health = health;
            _strength = strength;
            _stamina = stamina;
            _startingStamina = stamina;
        }
        public void Recharge()
        {
            _stamina = _startingStamina;
            Console.WriteLine(_name+ " had to recharge he has regained " + _startingStamina);
            Console.WriteLine("Trykk en tast for å gå tilbake til options");
            Console.ReadKey();
            Console.Clear();

        }
        public bool Fight(GameCharacter opponent)
        {


            Console.Clear();
            if(_stamina == 0)
            {
                Recharge();
                return false;
            }
            if(_name == "Boss")
            {
                Random random = new Random();
                _strength = random.Next(0, 31);
            }
                 
            opponent._health -= _strength;
            _stamina -= 10;

            if (opponent._health <= 0)
            {
                Console.WriteLine("We have a winner! Winner is " + _name);
                Console.ReadKey();
                return true;
                
            }

            Console.WriteLine(_name + " Has hit " + opponent._name + " for " + _strength + "damage!");
            Console.WriteLine(opponent._name + " has " + opponent._health + " health left.");
            Console.WriteLine("Trykk en tast for å gå tilbake til options");
            Console.ReadKey();
            Console.Clear();
            return false;
        }

    }
}
