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
            
            string pilet = "";
            string n1 = "";
            string n2 = "";

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
                        Console.WriteLine("Viga andmetega");
                    }
                    else
                    {
                        if (vanus >= 0 && vanus < 6)
                        {
                            hind -= hind * 0.90;
                            pilet = "tasuta";
                        }
                        else if (vanus > 6 && vanus < 14)
                        {
                            hind -= hind * 0.50;
                            pilet = "laste";
                        }
                        else if (vanus > 15 && vanus < 64)
                        {
                            hind -= hind * 0.25;
                            pilet = "täis";
                        }
                        else if (vanus > 65 && vanus < 109)
                        {
                            hind -= hind * 0.35;
                            pilet = "soodus";
                        }
                        
                            Console.WriteLine($"{nimi}, sul vaja maksta {hind} ja {pilet}pilet");
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
            Console.WriteLine("Tere naabrid !!! Mis on sinu nimi?");
            n1 = Console.ReadLine().ToUpper();
            Console.WriteLine($"Tere {n1}");
            Console.WriteLine("Tere naabrid !!! Mis on sinu nimi?");
            n2 = Console.ReadLine().ToUpper();
            Console.WriteLine($"Tere {n2}");
            if ((n1=="VG" && n2=="EL")||(n1 == "EL" && n2 == "VG"))
            {
                Console.WriteLine("Tere naabr!!!");
            }
            else if ((n1 == "ML" && n2 == "JL") || (n1 == "JL" && n2 == "ML") || (n1 == "JL" && n2 == "EDGOR") || (n1 == "EDGOR" && n2 == "JL"))
            {
                Console.WriteLine("Tere naabrid!!!");
            }
            else if((n1 == "SK" && n2 == "SAHA") || (n1 == "SAHA" && n2 == "SK") || (n1 == "SAHA" && n2 == "DAN") || (n1 == "DAN" && n2 == "SASHA"))
            {
                Console.WriteLine("Tere naabrid!!!");
            }
            else if ((n1 == "EL" && n2 == "AL") || (n1 == "AL" && n2 == "EL"))
            {
                Console.WriteLine("Tere naabr!!!");
            }
            else if (n1 == "MARK" && n2 == "MARK")
            {
                Console.WriteLine("Tere naabr!!!");
            }
            else
            {
                Console.WriteLine("EI tere !!!");
            }

            Console.WriteLine("Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala. ");
            string seinte = Console.ReadLine().ToUpper();
            if (seinte=="JAH")
            {
                
            }

            else if (seinte == "EI")
            {

            }







            Console.ReadKey();
        }
    }
}
