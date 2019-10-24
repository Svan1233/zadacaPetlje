using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricZadacaPetlje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi ocjenu");
            int brojac = 0;
            float prosjek = 0f;
            int zbrojOcjena = 0;
            int ocjena = Convert.ToInt16(Console.ReadLine());




            while (ocjena != 0)
            {
                if (ocjena == 1)
                {
                    prosjek = 1f;
                    ocjena = 0;
                }
                else
                {
                    zbrojOcjena = zbrojOcjena + ocjena;
                    brojac += 1;
                    Console.WriteLine("Upisi ocjenu: ");
                    ocjena = Convert.ToInt16(Console.ReadLine());
                    if (ocjena < 1 && ocjena > 5)
                    {
                        Console.WriteLine("Unio si ocjenu koja nije u intervalu od 1-5");
                        Console.WriteLine("Upisi ocjenu");
                        ocjena = Convert.ToInt16(Console.ReadLine());

                    }
                }
            }
                if (prosjek != 1)
                {
                    prosjek = zbrojOcjena / brojac;
                    Console.WriteLine("Prosijek ocjena je " + prosjek);
                }
                else
                {
                    Console.WriteLine("Prosjek ocjena je " + prosjek);
                }
            


                Console.ReadKey();

            }
    }
    }
