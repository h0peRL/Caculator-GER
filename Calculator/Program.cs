using System;

namespace Probe1_Delvecchio
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Willkommen zum Rechner... \n ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Um das Programm zu verlassen, geben sie ''exit'' oder ''quit'' ein und zur bestätigung ob sie das Programm verlassen wollen, geben sie Enter ein. \n");
            while (true) // Während true zutrifft...
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Geben Sie die erste Zahl ein:");
                    string ersteZahlAsString = Console.ReadLine();
                    if (ersteZahlAsString == "quit" || ersteZahlAsString == "exit") // bei exit oder quit wird das Programm verlassen
                    {
                        Console.WriteLine("Das Programm wird beendet..");
                        Environment.Exit(-1);
                    }
                    double ersteZahl = Convert.ToDouble(ersteZahlAsString); //konvertierung
                    Console.WriteLine("Wählen Sie die Operation: \n + \n - \n * \n : \n x^2 \n % \n sin \n cos \n tan \n bin \n hex ");
                    Console.WriteLine("--------------------------------------------");
                    string operation = Console.ReadLine();
                    switch (operation) // switch case bis ein case zutrifft
                    {
                        case "+":   // plus

                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("Geben Sie die zweite Zahl ein:");
                            string zweiteZahlAsString = Console.ReadLine();
                            if (zweiteZahlAsString == "quit" || zweiteZahlAsString == "exit")  // wird in jedem Case überprüft
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Das Programm wird beendet..");
                                Environment.Exit(-1);
                            }
                            double zweiteZahl;
                            zweiteZahl = Convert.ToDouble(zweiteZahlAsString);
                            Console.WriteLine(ersteZahl + " plus " + zweiteZahl + " gibt " + AdditionOperation(ersteZahl, zweiteZahl));    
                            break;
                        case "-":   // minus
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("Geben Sie die zweite Zahl ein:");
                            zweiteZahlAsString = Console.ReadLine();
                            if (zweiteZahlAsString == "quit" || zweiteZahlAsString == "exit")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Das Programm wird beendet..");
                                Environment.Exit(-1);
                            }
                            zweiteZahl = Convert.ToDouble(zweiteZahlAsString);
                            Console.WriteLine(ersteZahl + " minus " + zweiteZahl + " gibt " + SubtraktionOperation(ersteZahl, (int)zweiteZahl)); 
                            break;
                        case "*":   // mal
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("Geben Sie die zweite Zahl ein:");
                            zweiteZahlAsString = Console.ReadLine();
                            if (zweiteZahlAsString == "quit" || zweiteZahlAsString == "exit")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Das Programm wird beendet..");
                                Environment.Exit(-1);
                            }
                            zweiteZahl = Convert.ToDouble(zweiteZahlAsString);
                            Console.WriteLine(ersteZahl + " mal " + zweiteZahl + " gibt" + MultiplikationOperation(ersteZahl, zweiteZahl));
                            break;
                        case ":":   // geteilt
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("Geben Sie die zweite Zahl ein:");
                            zweiteZahlAsString = Console.ReadLine();
                            if (zweiteZahlAsString == "quit" || zweiteZahlAsString == "exit")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Das Programm wird beendet..");
                                Environment.Exit(-1);
                            }
                            zweiteZahl = Convert.ToDouble(zweiteZahlAsString);
                            Console.WriteLine(ersteZahl + " geteilt durch " + zweiteZahl + " gibt " + DivisionOperation(ersteZahl, zweiteZahl));
                            break;
                        case "x^2": // hoch 2 oder x *
                            Console.WriteLine("Die Zweierpotenz von " + ersteZahl + " ist " + ZweierPpotenzOperation(ersteZahl));
                            break;
                        case "%":   // Modulo
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("Geben Sie die zweite Zahl ein:");
                            zweiteZahlAsString = Console.ReadLine();
                            if (zweiteZahlAsString == "quit" || zweiteZahlAsString == "exit")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Das Programm wird beendet..");
                                Environment.Exit(-1);
                            }
                            zweiteZahl = Convert.ToDouble(zweiteZahlAsString);
                            Console.WriteLine("Der Modulo von " + ersteZahl + " und " + zweiteZahl + " ist " + ModuloOperation(ersteZahl, zweiteZahl));
                            break;
                        case "sin": // Sinus
                            Console.WriteLine("Der Sinus von " + ersteZahl + " ist " + SinusOperation(ersteZahl));
                            break;
                        case "cos": // Cosinus
                            Console.WriteLine("Der Cosinus von " + ersteZahl + " ist " + CosinusOperation(ersteZahl));
                            break;
                        case "tan": // Tangens
                            Console.WriteLine("Der Tangens von " + ersteZahl + " ist " + TangensOperation(ersteZahl));
                            break;
                        case "bin": // Binär
                            Console.WriteLine("Die Binärzahl von " + ersteZahl + " ist " + BinOperation((int)ersteZahl));
                            break;
                        case "hex": // Hexadezimal
                            Console.WriteLine("Die Hexadezimalzahl von " + ersteZahl + " ist " + HexOperation(ersteZahlAsString));
                            break;
                        case "quit":
                        case "exit":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Das Programm wird beendet..");
                            Environment.Exit(-1);
                            break;
                        default:
                            Console.WriteLine("\n--------------------------------------------\nBitte wählen Sie einer dieser Operatoren aus: \n + \n - \n * \n : \n x^2 \n % \n sin \n cos \n tan \n bin \n hex \n--------------------------------------------");
                            break;
                    }
                }
                catch (Exception) // fängt alle falschen eingaben auf (fehleingaben)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Fehleingabe...Bitte geben Sie eine Zahl an.");

                }

            }
        }
        //Ausgaben
        public static double AdditionOperation(double ersteZahl, double zweiteZahl)
        {
            return ersteZahl + zweiteZahl;
        }
        public static double SubtraktionOperation(double ersteZahl, int zweiteZahl)
        {
            return ersteZahl - zweiteZahl;
        }
        public static double MultiplikationOperation(double ersteZahl, double zweiteZahl)
        {
            return ersteZahl * zweiteZahl;
        }
        public static double DivisionOperation(double ersteZahl, double zweiteZahl)
        {
            return ersteZahl / zweiteZahl;
        }
        public static double ZweierPpotenzOperation(double ersteZahl)
        {
            return Math.Pow(ersteZahl, 2);
        }
        public static double ModuloOperation(double ersteZahl, double zweiteZahl)
        {
            return ersteZahl % zweiteZahl;
        }
        public static double SinusOperation(double ersteZahl)
        {
            return Math.Sin(ersteZahl);
        }
        public static double CosinusOperation(double ersteZahl)
        {
            return Math.Cos(ersteZahl);
        }
        public static double TangensOperation(double ersteZahl)
        {
            return Math.Tan(ersteZahl);
        }
        public static string BinOperation(int ersteZahl)
        {
            string binary = Convert.ToString(ersteZahl, 2);
            return binary;
        }
        public static string HexOperation(string ersteZahlAsString)
        {
            int ersteZahl = Convert.ToInt32(ersteZahlAsString);
            string Output = Convert.ToString(ersteZahl, 16);
            return Output;
        }
    }
}