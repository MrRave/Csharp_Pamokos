using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_pamokos
{
    class Pamoka5
    {
        static void Main(string[] args)
        {
            //pratimas1();
            //pratimas2();
            pratimas3();
        }

        static void pratimas1()
        {
            var number = 5;
            Console.WriteLine("start " + number);
            increaseNormal(number);
            Console.WriteLine("after normal " + number);
            increaseRef(ref number);
            Console.WriteLine("after ref: " + number);
            increaseOut(out number);
            Console.WriteLine("after out: " + number);
            Console.ReadLine();
        }

        static void increaseNormal(int number)
        {
            number++;
        }

        static void increaseRef(ref int number)
        {
            number++;
        }

        static void increaseOut(out int number)
        {
            number = 4;
            number++;
        }

        static Boolean pratimas2()
        {
            string zodis = Console.ReadLine();
            for (int i = 0; i < zodis.Length; i++)
            {
                char simbolis = zodis[i];
                if (simbolis != '0' && simbolis != '1' && simbolis != '2' && simbolis != '3' && simbolis != '4' && simbolis != '5' && simbolis != '6' && simbolis != '7' && simbolis != '8' && simbolis != '9')
                {
                    if (simbolis == '-' || i != 0 )
                    {
                        return false;
                    }
                    
                }

            }
            Console.ReadLine();
            return true;

        }

        static void pratimas3()
        {
            /*
            Console.WriteLine("irasyk 5 zodzius");
            string zodis1 = Console.ReadLine();
            string zodis2 = Console.ReadLine();
            string zodis3 = Console.ReadLine();
            string zodis4 = Console.ReadLine();
            string zodis5 = Console.ReadLine();
            string[] Masyvas1 = new string[5] { zodis1, zodis2, zodis3, zodis4, zodis5 };
            for (int i = 0; i < Masyvas1.Length; i++)
            {
                Console.WriteLine(Masyvas1[i] + " ");
                Console.ReadLine();
            }
            for (int i = 0; i < Masyvas1.Length; i++)
            {
                Console.WriteLine(zodis1 + " " + zodis2 + " " + zodis3 + " " + zodis4 + " " + zodis5);
                Console.ReadLine();
            }
            */
            // check Irina's Gist

            string[] data = { "Mano", "batai", "buvo", "Mano", "batai", "buvo", "du", "buvo", "du", "." };
            

        }


    }
}
