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
            start: // nezinojau kaip pasidaryt po antro if'o, jog iseitu is ciklo, isivaizduoju jog galejau daryt funkcija nauja... bet man regis turiu gap'a funkciju panaudojimui efektyviam
            string desimtys = "dafuq";
            Console.WriteLine("Iveskite skaiciu");
            string zodis_skaicius = Console.ReadLine();
            Console.WriteLine("Kompiliuojama - prasau palaukti...");
            for(int i = 0; i < zodis_skaicius.Length; i++)
            {
                char pirminis = zodis_skaicius[i];
                if (pirminis != '0' && pirminis != '1' && pirminis != '2' && pirminis != '3' && pirminis != '4' && pirminis != '5' && pirminis != '6' && pirminis != '7' && pirminis != '8' && pirminis != '9')
                {
                    if (pirminis == '-' || i != 0)
                    {
                        Console.WriteLine("neteisingas ivedimas");
                        goto start;
                    }
                    Console.WriteLine("teisingas ivedimas");
                    
                }
                
            }

            int zodis_skaicius_int = Convert.ToInt32(zodis_skaicius);
            
            int[] ivesties_galimybe = Enumerable.Range(-100000000, 200000000).ToArray(); //stackoverflow padejo cia, bet man regis int'egeris yra permazas sitai uzduociai ir neradau kaip pasidaryt i koki long'a...

            bool targetInArray = ivesties_galimybe.Contains(zodis_skaicius_int);  //same stackoverflow padejo cia, labai patogus funkcianalumas masyve .contains

            if (zodis_skaicius_int > 20 && zodis_skaicius_int < 100)
            {
                desimtys = funkcionalumas2(ref zodis_skaicius_int);
            }

            if (targetInArray == true)
            {
                Console.WriteLine("Ivedimas teisingas");
                //funkcionalumas(zodis_skaicius_int);
                //funkcionalumas2(zodis_skaicius_int);
                Console.WriteLine(desimtys +"salala"+ funkcionalumas(zodis_skaicius_int)); //nesuprantu kodel nespausdina paskutines dalies
            }
            else
            {
                Console.WriteLine("Ivedimas neteisingas, bandyk dar karta");
                goto start;
            }
            //Console.WriteLine(targetInArray);
            Console.ReadLine();
        }
        static string funkcionalumas (int vartotojo_skaicius) //referinta i Edgaro aprasyma
        {
            string pavadinimas = "";
            switch (vartotojo_skaicius)
            {
                case 1:
                    pavadinimas = "vienas ";
                    break;
                case 2:
                    pavadinimas = "du ";
                    break;
                case 3:
                    pavadinimas = "trys ";
                    break;
                case 4:
                    pavadinimas = "keturi ";
                    break;
                case 5:
                    pavadinimas = "penki ";
                    break;
                case 6:
                    pavadinimas = "sesi ";
                    break;
                case 7:
                    pavadinimas = "septyni ";
                    break;
                case 8:
                    pavadinimas = "astuoni ";
                    break;
                case 9:
                    pavadinimas = "devyni ";
                    break;
                case 10:
                    pavadinimas = "desimt ";
                    break;
                case 11:
                    pavadinimas = "vienuolika ";
                    break;
                case 12:
                    pavadinimas = "dvylika ";
                    break;
                case 13:
                    pavadinimas = "trylikta ";
                    break;
                case 14:
                    pavadinimas = "keturiolika ";
                    break;
                case 15:
                    pavadinimas = "penkiolika ";
                    break;
                case 16:
                    pavadinimas = "sesiolika ";
                    break;
                case 17:
                    pavadinimas = "septyniolika ";
                    break;
                case 18:
                    pavadinimas = "astuoniolika ";
                    break;
                case 19:
                    pavadinimas = "devyniolika ";
                    break;
                case 20:
                    pavadinimas = "dvidesimt ";
                    break;
                case 30:
                    pavadinimas = "trisdesimt ";
                    break;
                case 40:
                    pavadinimas = "keturiasdesimt ";
                    break;
                case 50:
                    pavadinimas = "penkiasdesimt ";
                    break;
                case 60:
                    pavadinimas = "sesiasdesimt ";
                    break;
                case 70:
                    pavadinimas = "septyniasdesimt ";
                    break;
                case 80:
                    pavadinimas = "astuoniasdesimt ";
                    break;
                case 90:
                    pavadinimas = "devyniasdesimt ";
                    break;
            }
            return pavadinimas;
        }
        static string funkcionalumas2 (ref int vartotojo_skaicius) //reiktu reminderio del REF funkcionalumo ir kaip ji galima butu cia pritaikyt ji
        {
            string pavadinimas2 = "";
            if (vartotojo_skaicius > 20 && vartotojo_skaicius < 30)
            {
                pavadinimas2 = "Dvidesimt ";                
            }
            else if (vartotojo_skaicius > 30 && vartotojo_skaicius <40)
            {
                pavadinimas2 = "Trisdesimt ";
            }
            return pavadinimas2;
        }

        // Random stuff below

        /*
        Console.WriteLine("Iveskite skaiciu nuo 9 iki -9");
        string[] ivesties_galimybe = new string[19] { "-9", "-8", "-7", "-6", "-5", "-4", "-3", "-2", "-1", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string zodis_skaicius = Console.ReadLine();
        bool targetStringInArray = ivesties_galimybe.Contains(zodis_skaicius);

        if (targetStringInArray == true)
        {
            Console.WriteLine("Ivedimas teisingas");
;
        }
        else
        {
            Console.WriteLine("Ivedimas neteisingas, bandyk dar karta");

        }
        Console.WriteLine(targetStringInArray);
        Console.ReadLine();

        Console.WriteLine("Iveskite skaiciu nuo 1 iki 10");
        int skaicius = Convert.ToInt32(Console.ReadLine());
        if (skaicius > 0 && skaicius < 10)
        {
            switch (skaicius)
            {
                case 1:
                    Console.WriteLine("vienas ");
                    break;
                case 2:
                    Console.WriteLine("du ");
                    break;
                case 3:
                    Console.WriteLine("trys ");
                    break;
                case 4:
                    Console.WriteLine("keturi ");
                    break;
                case 5:
                    Console.WriteLine("penki ");
                    break;
                case 6:
                    Console.WriteLine("sesi ");
                    break;
                case 7:
                    Console.WriteLine("septyni ");
                    break;
                case 8:
                    Console.WriteLine("astuoni ");
                    break;
                case 9:
                    Console.WriteLine("devyni ");
                    break;
                case 10:
                    Console.WriteLine("desimt ");
                    break;

                default:
                    Console.WriteLine("neteisingas skaicius");
                    break;
            }

            string vardas = Convert.ToString(skaicius);
            Console.WriteLine("Tavo ivestas skaicius zodziais " + vardas);

        }
        */


        //pratimas1();

        //pratimas3();


        /*
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
        */
        /*
        void pratimas2()
        {
            Console.WriteLine("Iveskite skaiciu nuo 9 iki -9");
            string[] ivesties_galimybe = new string[19] { "-9", "-8", "-7", "-6", "-5", "-4", "-3", "-2", "-1", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string skaicius = Console.ReadLine();
            bool targetStringInArray = ivesties_galimybe.Contains(skaicius);
            Console.WriteLine(targetStringInArray);
            Console.ReadLine();
        */
        /*
        for (int i = 0; i < skaicius.Length; i++)
        {
            char simbolis = skaicius[i];
            if (simbolis != '0' && simbolis != '1' && simbolis != '2' && simbolis != '3' && simbolis != '4' && simbolis != '5' && simbolis != '6' && simbolis != '7' && simbolis != '8' && simbolis != '9')
            {
                if (simbolis == '-' || i != 0 )
                {
                    Console.WriteLine("neteisingas ivedimas");
                    return false;
                }


            }

        }
        Console.WriteLine("ivestis teisinga");
        Console.ReadLine();
        return true;

    }*/
        /*
        static void pratimas3()
        {
            
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
            
            // check Irina's Gist

            string[] data = { "Mano", "batai", "buvo", "Mano", "batai", "buvo", "du", "buvo", "du", "." };
            

        }
        */

    }
}
