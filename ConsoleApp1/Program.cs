using System;

namespace TPGITAVANCE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue sur le jeu Pierre Feuille Ciseau !!!!!");

            int choice;
            do
            {
                Console.Write(getMainMenu());
                choice = Convert.ToInt32(Console.ReadLine());
                string result = ComputeMainMenuChoice(choice);
                Console.WriteLine(result);
            } while (choice != 1 || choice != 2 || choice != 3);
            Console.ReadLine();
        }

        public static string getMainMenu()
        {
            return " ****** Menu ******\n "
                    + " 1 – Jouer\n "
                    + " 2 – Options\n "
                    + " 3 – Quitter\n "
                    + " Choice ? : ";
        }
        public static string ComputeMainMenuChoice(int choice)
        {
            string result = " ";
            switch (choice)
            {
                case 1:
                    result += " –> Add Item ";
                    break;
                case 2:
                    result += "–> Item update ";
                    break;
                case 3:
                    result += "–> Item retrieved ";
                    break;
                case 4:
                    result += "–> Item deleted ";
                    break;
                case 5:
                    result += "–> Bye bye! ";
                    break;
                default:
                    result += "Bad choice, try again ";
                    break;
            }
            return result;
        }

    }
}



