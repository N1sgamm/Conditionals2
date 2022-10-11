using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals2
{
    internal class Program
    {
        static int health;
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals 2:");
            Console.WriteLine();

            health = 100;
            Console.WriteLine("Health :" + health);
            TakeDamage(10);
            ShowHUD();

            Console.ReadKey(true);
        }
        static void TakeDamage(int damage)
        {
            Console.WriteLine("Player is about to take " + damage + " damage...")
            health = health - damage;

            if (health < 0)
            {
                health = 0;
            }
        }
        static void ShowHUD()
        {
            Console.WriteLine("Health: " + health);

            string status;
            status = "";

            if ((health >= 50) && (health <= 75)) // && means "and"
            {
                if (health <= 75)
                {
                    status = "HURT";
                }
            }
        }
    }
}
