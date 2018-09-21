using System;
using AccountManagement.Model;

namespace AccountManagement.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("0123456789", "password", 100000  );

            string password;
            string userChoice;
            string credit;
            string debit;

           

            do
            {
                Console.WriteLine("Bonjour Utilisateur, que voulez vous faire ? ");
                Console.WriteLine("1 - Consulter solde");
                Console.WriteLine("2 - Crédit");
                Console.WriteLine("3 - Débit");
                Console.WriteLine("4 - Changer de password");
                Console.WriteLine("5 - Quitter");
                
                userChoice = Console.ReadLine();

                Console.Clear();


                switch (userChoice)
                {
                    case "1":
                        do
                        {
                            Console.Write("Password : ");
                            password = Console.ReadLine();

                        } while (!account.VerifPassword(password));
                        Console.WriteLine("Votre solde est de : {0} centimes d'euros ", account.CurrentBalance);
                        break;
                
                    case"2" :
                        do
                        {
                            Console.Write("Password : ");
                            password = Console.ReadLine();

                        } while (!account.VerifPassword(password));
                        Console.WriteLine("Combien voulez vous créditer ? ");
                        credit = Console.ReadLine();
                        uint creditParse = uint.Parse(credit);
                        account.Credit(creditParse);
                        break;

                    case "3":
                        do
                        {
                            Console.Write("Password : ");
                            password = Console.ReadLine();

                        } while (!account.VerifPassword(password));
                        Console.WriteLine("Combien voulez vous déditer ? ");
                        debit = Console.ReadLine();
                        uint debitParse = uint.Parse(debit);
                        account.Withdraw(debitParse);
                        break;

                    case "4":
                        do
                        {
                            Console.Write("Password : ");
                            password = Console.ReadLine();

                        } while (!account.VerifPassword(password));
                        Console.WriteLine("Nouveau password : ");
                        password = Console.ReadLine();
                        account.ChangePassword = password;
                        
                        break;
                }

            } while (userChoice != "5");
            Console.ReadKey();
           
        }
    }
}
