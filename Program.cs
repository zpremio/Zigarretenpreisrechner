using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zigarretenpreisrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                const double Einzelpreis = 0.25;
                double PreisProTag = 0, PreisProJahr = 0;
                double KostenBisher = 0, Kosten65, KostenGesamt;

                int alter = 0;
                int anfangsaltereingabe, anfangsalter = 0, zwischenalter = 0;
                int AnzahlProTagEingabe, AnzahlProTag = 0;



                Console.WriteLine("Willkommen beim Zigarreten Preis Rechner!");

                bool balter = true;
                while (balter == true)
                {
                    Console.Write("Gebe bitte dein Alter ein: ");
                    try
                    {
                        alter = Convert.ToInt32(Console.ReadLine());
                        balter = false;
                    }
                    catch { Console.WriteLine("Überprüfe bitte deine Eingabe!"); }


                }
                bool banfangsalter = true;
                while (banfangsalter == true)
                {
                    Console.Write("Gebe bitte an in welchem Alter du Angefangen hast: ");
                    try
                    {
                        anfangsalter = Convert.ToInt32(Console.ReadLine());
                        banfangsalter = false;
                    }
                    catch { Console.WriteLine("Überprüfe bitte deine Eingabe1!"); }
                }
                bool bAnzahlProTag = true;
                while (bAnzahlProTag == true)
                {
                    Console.Write("Gebe bitte an wie viele Zigaretten du pro Tag rauchst: ");
                    try
                    {
                        AnzahlProTag = Convert.ToInt32(Console.ReadLine());
                        bAnzahlProTag = false;
                    }
                    catch { Console.WriteLine("Überprüfe bitte deine Eingabe2!"); }
                }

                PreisProTag = AnzahlProTag * Einzelpreis;
                PreisProJahr = PreisProTag * 365;
                zwischenalter = alter - anfangsalter;

                KostenBisher = zwischenalter * PreisProJahr;
                Kosten65 = alter - 65 * PreisProJahr + KostenBisher;
                KostenGesamt = KostenBisher + Kosten65;




                //Debug
                Console.WriteLine("PreisProTag: " + PreisProTag);
                Console.WriteLine("PreisProJahr: " + PreisProJahr);
                Console.WriteLine("ZwischenAlter: " + zwischenalter);
                Console.WriteLine("KostenBisher: " + KostenBisher);
                Console.WriteLine("Kosten65: " + Kosten65);
                Console.WriteLine("KostenGesamt: " + KostenGesamt);

                /*string nein, ja;
                Console.WriteLine("Möchtest du eine neue Berechnung starten? (Y/N): ");*/
                


            }
            Console.ReadKey();
        }
    }
}
