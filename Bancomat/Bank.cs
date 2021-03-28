using System;
using System.Collections.Generic;
using System.Threading;


namespace HoweWork_9_Bancomat.Bancomat
{
    public class Bank
    {
        public List<Account> accounts = new List<Account>();

        public Account Search(string cardNumber)
        {
            foreach (Account account in accounts)
            {
                if (account.cardNumber == cardNumber)
                {
                    return account;
                }
            }
            Console.WriteLine("Карта с таким номером не зарегистрирована в системе");
            Console.ReadLine();
            return null;
        }

        public static bool Authorization(Bank bank, out Account account)
        {
            string cardNumber;
            int wrongPasswordsCount = 0;

            Client.EnterCardNumber(out cardNumber);
            account = bank.Search(cardNumber);

            if (account == null) return false;

            else
            {
                while (true)
                {
                    int password;
                    if (wrongPasswordsCount == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("3 неудачных попытки!");
                        Thread.Sleep(700);
                        Console.ResetColor();
                        return false;
                    }

                    Client.EnterPassword(out password);

                    if (account.password != password)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверный пароль. Попробуйте еще раз");
                        Thread.Sleep(700);
                        Console.Clear();
                        wrongPasswordsCount++;
                        Console.ResetColor();
                        continue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Верный пароль");
                        Thread.Sleep(700);
                        Console.Clear();
                        Console.ResetColor();
                        return true;
                    }
                }
            }
        }
    }
}
