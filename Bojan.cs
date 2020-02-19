using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //boolean för att ha programmet igång och avsluta vid inmatning
            bool körProgrammet = true;
            while (körProgrammet)
            {

                //try är för exceptions och avslutas med catch
                try
                {

                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Välj siffra i menyn: 0 1 2 3 4 5 6 7 8 9 10 11 12");
                
                Console.ResetColor();
                int caseSwitch = int.Parse(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 0:
                        Console.WriteLine("Programet är avslutad\nTryck Enter för att stänga ner!");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Hello World!");
                        break;
                    case 2:
                        Console.Write("Skriv ditt namn: ");
                        String personensNamn = Console.ReadLine();
                        Console.Write("Skriv ditt efternamn: ");
                        String personensEfternamn = Console.ReadLine();
                        Console.Write("Skriv din ålder: ");
                        int personensÅlder = int.Parse(Console.ReadLine());                       
                        Console.WriteLine("Här är dina input: " + personensNamn + " " + personensEfternamn + " " + personensÅlder);
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ändra bakgrundens och textensfärg");
                        break;
                    case 4:
                        Console.WriteLine("Visar dagens datum i en härlig färg:");
                        DateTime date1 = new DateTime(2008, 4, 10);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(date1.ToString("d"));
                        Console.ResetColor();
                        break;
                    case 5:
                        Console.WriteLine("Uppge två värden");
                        int värde1 = int.Parse(Console.ReadLine());
                        int värde2 = int.Parse(Console.ReadLine());
                        
                        int[] numbers = new int[] { värde1, värde2 };
                        int störst = numbers.Max();
                        Console.WriteLine("Detta värdet är störst: " + störst);
                        break;
                    case 6:
                        String gissaOrdet = "boll";
                        String gissa = "";
                        int försök = 0;
                        int antalförsök = 3;
                        bool ingaförsökkvar = false;

                        while (gissa != gissaOrdet && !ingaförsökkvar)
                        {
                            if(försök < antalförsök)
                            {
                                Console.WriteLine("GISSNINGSSPELET\nGissa rätt ord: ");
                                gissa = Console.ReadLine();
                                försök++;
                            }
                            else
                            {
                                ingaförsökkvar = true;
                            }
                        }

                        if (ingaförsökkvar)
                        {
                        Console.WriteLine("Inga försökkvar, tyvärr!");
                        }
                        else
                        {
                                Console.WriteLine("Du har gissat RÄTT!");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Skriv en textrad som kommer att sparas i textfilen 'NyTextRad.txt'");
                        String textRad = Console.ReadLine();
                            using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter(@"C:\Users\Lexicon\source\repos\Test\Test\NyTextRad.txt", true))
                        {
                            file.WriteLine(textRad);
                        }
                        Console.WriteLine("Textraden har sparats\nTryck enter för att läsa från filen!");
                            Console.ReadLine();

                            string text = System.IO.File.ReadAllText(@"C:\Users\Lexicon\source\repos\Test\Test\NyTextRad.txt");
                            System.Console.WriteLine("Innehåll i filen 'NyTextRad.txt':\n{0}", text);
                            break;
                    case 8:
                        Console.Write("Säker att du vill avsluta? Y / N: ");
                        string go = Console.ReadLine();
                        if (go.ToUpper() == "Y")
                        {
                        körProgrammet = false;
                        }
                        break;
                    case 9:
                        int rättsiffra = 8;
                        int siffran = 0;

                        Console.WriteLine("Gissa rätt siffra: ");
                        int.TryParse(Console.ReadLine(), out siffran);

                        while (siffran!=rättsiffra)
                        {
                            Console.WriteLine("Gissa rätt siffra: ");
                            int.TryParse(Console.ReadLine(), out siffran);

                        }
                        
                            Console.WriteLine("{0} Bra gissat! Grattis!", siffran);

                        break;
                    case 10:
                        int numberToGuess = 54;
                        int userGuess = 0;

                        while (userGuess != numberToGuess)
                        {
                            Console.Write("Gissa rättsiffra: ");
                            int.TryParse(Console.ReadLine(), out userGuess);

                            if (userGuess > numberToGuess)
                            {
                                Console.WriteLine("{0} is too high!", userGuess);
                            }
                            else if (userGuess < numberToGuess)
                            {
                                Console.WriteLine("{0} is too low!", userGuess);
                            }
                            else
                            {
                                Console.WriteLine("{0} is right! Congratulations.", userGuess);
                            }
                        }
                        break;
                    case 11:
                        const int MAX_NUMBER = 100;
                        Random random = new Random();
                        int gissanummret = random.Next(MAX_NUMBER) + 1;
                        int dingissning = 0;
                        int guesses = 0;

                        Console.WriteLine("GISSA NUMMRET!");
                        Console.WriteLine("mellan 1 och {0}.", MAX_NUMBER);

                        while (dingissning != gissanummret)
                        {
                            guesses++;
                            Console.Write("Skriv din gissning: ");
                            int.TryParse(Console.ReadLine(), out dingissning);

                            if (dingissning > gissanummret)
                            {
                                Console.WriteLine("{0} Är för högt!", dingissning);
                            }
                            else if (dingissning < gissanummret)
                            {
                                Console.WriteLine("{0} Är för lågt!", dingissning);
                            }
                            else
                            {
                                Console.WriteLine("{0} ÄR KORREKT! Grattis.", dingissning);
                                Console.WriteLine("Din antal gissningar: {0}", guesses);
                            }
                        }
                        break;
                    case 12:
                        Console.WriteLine("Hitta talet i containern!\nSiffrorna ligger i följd.\nUppge platsen: ");
                        int[] minanummer = { 2, 6, 4, 8, 9, 5, 1, 4, 6, 8, 32 };
                        int talet = int.Parse(Console.ReadLine());
                        Console.WriteLine("Siffran i conteinern på plats: " + talet);
                        Console.WriteLine("Är siffran: " + minanummer[talet]);
                        break;
                        default:
                        Console.WriteLine("Ogiltig inmatning, prova igen:");
                        break;
                   
            }
            }
                catch (FormatException e)
                {
                Console.WriteLine(e.Message + "\nExceptions i C# is grejt.\nProva igen med ny inmatning!");
                }
                
            }
            
        }
    }
}
