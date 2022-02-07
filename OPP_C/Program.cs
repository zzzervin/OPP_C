using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_C
{
    class Program
    {
        static void Main(string[] args)
        {
            double hind = 15;

            Console.WriteLine("Tere tulemast!!! Mis on sinu nimi?");
            Console.Title = "Pealkiri";
            string nimi = Console.ReadLine();
            char[] tahed = nimi.ToCharArray();//juku->["j","u","k","u"]
            int i = 0;
            nimi = "";
            foreach (var t in tahed)
            {
                if (i==0)
                {
                    nimi += t.ToString().ToUpper();
                }
                else
                {
                    nimi += t.ToString().ToLower();
                }
                i++;
            }

            
            Console.WriteLine("Tere {0}", nimi);
            Console.WriteLine($"Tere {nimi}");
            if (nimi.ToUpper()=="JUKU" || nimi.ToLower() == "ervin")
            {
                Console.WriteLine($"Tule kulla! {nimi} kas tahat kinno?");
                string vastus = Console.ReadLine();
                if (vastus.ToUpper()=="JAH" || vastus.ToUpper() == "ДА")
                {
                    Console.WriteLine($"kui vana {nimi}?");
                    int vanus = int.Parse(Console.ReadLine());
                    
                    if (vanus<=0  || vanus > 109)
                    {
                        Console.WriteLine("Viga");
                    }
                    else
                    {
                        if (vanus >= 0 && vanus < 8)
                        {
                            hind -= hind * 0.5;
                        }
                        else if (vanus >= 8 && vanus < 18)
                        {
                            hind -= hind * 0.25;
                        }
                        else
                        {
                            Console.WriteLine("0%");
                        }
                        Console.WriteLine($"{nimi}, sul vaja maksta {hind}");
                    }

                }
                else if (vastus.ToUpper() == "EI" || vastus.ToUpper() == "НЕТ")
                {
                    Console.WriteLine($"Ei taha?! {nimi}" );
                }
            }
            else 
            {
                Console.WriteLine($"Tana ma olen hoivatud! {nimi}");
            }



            Console.ReadKey();
        }
    }
}
