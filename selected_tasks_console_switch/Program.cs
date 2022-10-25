using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aufgabe_____Schreibe ein Programm, dass den Betrag einer ausgewählten Währung in eine andere umrechnet!*/

            Console.WriteLine("ConsoleWährungen");
            Console.WriteLine();

            int endCounter = 0;
            while (endCounter != 1)
            {
                Console.WriteLine("Vorhandene Währungen: EUR, USD, CHF, GBP, JPY, CNY, DKK, NOK, SEK");
                Console.WriteLine();
                Console.Write("Geben Sie den Betrag in Euro ein: ");
                double iAmount = Convert.ToDouble(Console.ReadLine());
                Console.Write("Geben Sie die Ziel-Währunng ein: ");
                string iCurrency = (Console.ReadLine());
                Console.WriteLine();
                switch (iCurrency.ToUpper())
                {
                    case "EUR":
                        Console.WriteLine(iAmount + " EUR entsprechen " + iAmount * 1 + " EUR");
                        break;
                    case "USD":
                        Console.WriteLine(iAmount + " EUR entsprechen " + (iAmount * 1.02) + " USD");
                        break;
                    case "CHF":
                        Console.WriteLine(iAmount + " EUR entsprechen " + iAmount * 0.99 + " CHF");
                        break;
                    case "GBP":
                        Console.WriteLine(iAmount + " EUR entsprechen " + iAmount * 0.85 + " GBP");
                        break;
                    case "JPY":
                        Console.WriteLine(iAmount + " EUR entsprechen " + iAmount * 141.39 + " JPY");
                        break;
                    case "CNY":
                        Console.WriteLine(iAmount + " EUR entsprechen " + iAmount * 6.90 + " CNY");
                        break;
                    case "DKK":
                        Console.WriteLine(iAmount + " EUR entsprechen " + iAmount * 7.44 + " DKK");
                        break;
                    case "NOK":
                        Console.WriteLine(iAmount + " EUR entsprechen " + iAmount * 10.13 + " NOK");
                        break;
                    case "SEK":
                        Console.WriteLine(iAmount + " EUR entsprechen " + iAmount * 10.46 + " SEK");
                        break;
                    default:
                        Console.WriteLine("Falsche Eingabe");
                        break;
                }

                Console.WriteLine();
                int i = 0;
                while (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Programm beenden? Ja / Nein: ");
                    string str = Console.ReadLine();
                    Console.WriteLine();
                    switch (str.ToUpper())
                    {
                        case "JA":
                            endCounter = 1;
                            i = 1;
                            break;
                        case "NEIN":
                            endCounter = 0;
                            i = 1;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Falsche Eingabe. Bitte geben Sie Ja oder Nein ein.");
                            i = 0;
                            continue;
                    }
                }
            }



            /*Aufgabe_______Programmieren Sie ein Minispiel, dass den Spieler eine gewürfelte Zahl erraten lässt!*/

            //Console.WriteLine("ConsoleZahlenRaten");
            //Console.WriteLine();

            //int endCounter = 0;
            //while (endCounter != 1)
            //{
            //    Random r = new Random();
            //    int nZufall = r.Next(1, 7);
            //    Console.WriteLine("es wurde eine Zufallszahl zwischen 1 und 6 erzeugt: *");
            //    Console.Write("Erraten Sie die Zahl: ");
            //    int zZahl = Convert.ToInt32(Console.ReadLine());
            //    bool check = true;
            //    while (check)
            //    {
            //        switch (nZufall)
            //        {
            //            case var value when value == zZahl:
            //                Console.WriteLine("Herzlichen Glückwunsch");
            //                check = false;
            //                break;
            //            default:
            //                Console.WriteLine();
            //                Console.Write("Versuchen Sie es noch einmal ");
            //                zZahl = Convert.ToInt32(Console.ReadLine());
            //                continue;
            //        }
            //    }

            //    Console.WriteLine();
            //    int i = 0;
            //    while (i == 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.Write("Wollen Sie noch einmal spielen? Ja / Nein: ");
            //        string str = Console.ReadLine();
            //        Console.WriteLine();
            //        switch (str.ToUpper())
            //        {
            //            case "JA":
            //                endCounter = 1;
            //                i = 1;
            //                break;
            //            case "NEIN":
            //                endCounter = 0;
            //                i = 1;
            //                break;
            //            default:
            //                Console.ForegroundColor = ConsoleColor.White;
            //                Console.WriteLine("Falsche Eingabe. Bitte geben Sie Ja oder Nein ein.");
            //                i = 0;
            //                continue;
            //        }
            //    }
            //}
        }
    }
}
