using System;

namespace TPGITAVANCE
{
    class Program
    {
        private static string _UserChoice;
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue sur le jeu Pierre Feuille Ciseau !!!!!");

            Console.WriteLine(ShowMainMenu());

            bool choiceOK = true;

            do
            {
                _UserChoice = Console.ReadLine();

                switch (_UserChoice)
                {
                    case "1":
                        Console.Clear();
                        //Execution du code pour jouer
                        break;
                    case "2":
                        Console.Clear();
                        //Execution du code pour changer de nombre de joueur                      
                        break;
                    case "3":
                        //
                        Console.Clear();
                        Console.WriteLine("bye ! ");
                        Console.ReadKey();
                        choiceOK = false;
                        break;
                    default:
                        Console.WriteLine("saisie invalide, veuillez recommencer");
                        break;
                }
            } while (choiceOK);
        }

        public static string ShowMainMenu()
        {
            return " ****** Menu ******\n "
                    + " 1 – Jouer\n "
                    + " 2 – Options\n "
                    + " 3 – Quitter\n "
                    + " Choice ? : ";
        }
       

    }
}



