using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextConvert
{
    static class Menu
    {
        static private int menuChoice = 0;

        private static int whichMenu() => menuChoice;
        private static void setMenu(int choice) => menuChoice = choice;

        static public void menu_one()
        {
            Console.WriteLine("You are in menu_one! -- MainMenu");

            try
            {
                Console.WriteLine("Please enter a menu option 1-3");

                int userChoice = Int32.Parse(Console.ReadLine());
                setMenu(userChoice);
                switch (whichMenu())
                {
                    case 1:
                        menu_one();
                        break;
                    case 2:
                        menu_two();
                        break;
                    case 3:
                        menu_three();
                        break;
                    default:
                        Console.WriteLine("Exiting application");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break; 
                }
            }
            catch (FormatException e)
            {

                Console.WriteLine(e.Message);
                menu_one();
            }
        }

        // text to lowercase menu

        static private void menu_two()
        {
            string userString;
            string converted;
            Console.WriteLine("Enter all the text you need to convert");

            userString = Console.ReadLine();
            converted = conversionMethods.ConvertText_LC(userString);
            SetClipBoradData(converted);


            Console.WriteLine(converted);
            Console.WriteLine("Displayed above is your converted text");
            Console.WriteLine("The converted text is also on your system Clipboard");
            Console.ReadKey();
        }

        // text to camelCase menu

        static private void menu_three()
        {
            string userString;
            string converted;
            Console.WriteLine("Enter all the text you need to convert - menu_three");

            userString = Console.ReadLine();
            converted = conversionMethods.ConvertText_CC(userString);

            SetClipBoradData(converted);
            Console.WriteLine(converted);
            Console.WriteLine("Displayed above is your converted text");
            Console.WriteLine("The converted text is also on your system Clipboard");
            Console.ReadKey();
        }

        //text to clipboard
        static private void SetClipBoradData(string ustring)
        {
            try
            {
                //string clipboardData = null;
                Exception threadEx = null;
                Thread staThread = new Thread(
                    delegate ()
                    {
                        try
                        {
                            Clipboard.SetText(ustring);
                        }

                        catch (Exception ex)
                        {
                            threadEx = ex;
                        }
                    });
                staThread.SetApartmentState(ApartmentState.STA);
                staThread.Start();
                staThread.Join();
               
            }
            catch (Exception exception)
            {
                
            }
        }

        //TODO text to file sub-menu

   
        //TODO text to uppercase menu

        //TODO text proper format menu
    }
}
