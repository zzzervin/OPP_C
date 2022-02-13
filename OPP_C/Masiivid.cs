using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_C
{
    class Masiivid
    {
        static void Main(string[] args) 
        {

            Random rnd = new Random();
            /*
            int[] arvud = new int[10];
            int N = rnd.Next(10, 100);
            int M = rnd.Next(10, 100);
            Console.Write($"N=({ N })");
            Console.Write($"M=({ M })");
            Console.WriteLine();
            int i;
            if (N>M)
            {
                int abi = N;
                N = M;
                M = abi;
            }
            int[] NM = new int[M - N + 1];
            
            for (i = N; i < M; i++)
            {
                NM[i-N] = i;
                Console.WriteLine($"{i,4}");
                Console.WriteLine(i*i);
            }
            */
            /*
            int[] b = new int[5] ;
            int i;

            for (i = 0; i < b.Length; i++)
            {
                Console.WriteLine("Küsi kasutajalt viis arvu, salvesta neid massiivi");
                b[i] = int.Parse(Console.ReadLine());
                
            }
            int summ = 0;
            int korrutis = 1;
            foreach (int arv in b)
            {
                summ += arv;
                korrutis *= arv;
                
            }
            Console.WriteLine($"{summ}");
            Console.WriteLine($"{korrutis}");
            Console.WriteLine($"{summ / b.Length}");
            */
            /*
            string[] nimed = new string[5] { "Ervingh", "Oligarh", "Dina", "Maha", "Arbuz" };
            int a=0;
            Console.Write("jrkorde number");
             
             do
             {
                 Console.Write("jrkorde number(tavaline inimene)1-5: ");//1.2,3.4,5
                 try
                 {
                     a = int.Parse(Console.ReadLine());
                 }
                 catch (Exception e)
                 {

                     Console.WriteLine(e);
                 }

             } while (a<=1 || a>6);
             Console.WriteLine(nimed[a-1]);
             */

            /*
            string[] b = new string[4];
            int i;
            string ARV="";
            
            for (i = 0; i < b.Length; i++)
            {
                Console.WriteLine("numbrit");
                b[i] = (Console.ReadLine());
                
            }
            Array.Sort(b);
            Array.Reverse(b);
            for (i = 0; i < b.Length; i++)
            {
                ARV += b[i];
            }
           
            Console.Write(ARV);
            */
            /*
            int i=1;                      
            do
            {
                    
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.Write($"{i * j,4}");                         
                        }
                        Console.WriteLine();
                        i += 1;

            } while (i<=10);
            */
            /*
            string S;
            int Q=0 ;
            do
            {                     
                Console.WriteLine($"Osta elevant ära!");
                Q += 1;
                    
                S = Console.ReadLine().ToLower();

            } while (S!= "elevant");
            */
            Console.ReadKey();
        }
    }
}
