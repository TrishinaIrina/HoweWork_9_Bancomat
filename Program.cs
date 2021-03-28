using System;
using System.Threading;

namespace HoweWork_9_Bancomat
{
    class Program
    {
        /*3.	Реализовать классы Banc, Client, Account в различных пространствах имен (общее пространство имен «Bankomat»). 
        Изначально клиенту нужно открыть счёт в банке, получить номер счёта, получить свой пароль, положить сумму на счёт.
          4.	Приложение предлагает ввести пароль предполагаемой кредитной карточки, даётся 3 попытки на правильный ввод пароля. 
        Если попытки исчерпаны, приложение выдаёт соответствующее сообщение и завершается.
          5.	При успешном вводе пароля выводится меню. Пользователь может выбрать одно из нескольких действий:
                a.	вывод баланса на экран;
                b.	пополнение счёта;
                c.	снять деньги со счёта;
                d.	выход.
          6.	Если пользователь выбирает вывод баланса на экран, приложение отображает состояние предполагаемого счёта, 
        после чего предлагает либо вернуться в меню, либо совершить выход.
          7.	Если пользователь выбирает пополнение счёта, программа запрашивает сумму для пополнения и выполняет операцию, 
        сопровождая её выводом соответствующего комментария. Затем следует предложение вернуться в меню или выполнить выход.
          8.	Если пользователь выбирает снять деньг со счёта, программа запрашивает сумму. 
        Если сумма превышает сумму счёта пользователя, программа выдаёт сообщение и переводит пользователя в меню. 
        Иначе отображает сообщение о том, что сумма снята со счёта и уменьшает сумму счёта на указанную величину.
*/
        static void Main(string[] args)
        {
            Bancomat.Bank bank = new Bancomat.Bank();

            while (true) //программа, как и реальный банкомат будет работать условно бесконечно
            {
                try
                {
                    Bancomat.Account account = null;

                    Console.Clear();
                    Console.WriteLine("Добро пожаловать!");
                    Thread.Sleep(1200);

                    Console.Clear();
                    Bancomat.Client.StartMenu();

                    int userChoice = Bancomat.Client.UserChoice1();

                    if (userChoice == 1)
                    {
                        Console.Clear();
                        account = Bancomat.Client.Registration();
                        bank.accounts.Add(account);
                        Bancomat.Client.ShowRegestrationInfo(account);
                        Console.ReadLine();
                        continue;
                    }

                    else
                    {
                        Console.Clear();
                        if (Bancomat.Bank.Authorization(bank, out account))
                        {
                            int choice = 0;
                            while (true)
                            {
                                Console.Clear();
                                Bancomat.Client.Menu();
                                userChoice = Bancomat.Client.UserChoice2();
                                switch (userChoice)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Bancomat.Client.ShowBalance(account);
                                            Console.ReadLine();
                                            Console.Clear();
                                            choice = Bancomat.Client.MenuOrExit();
                                            if (choice == 1) continue;
                                            else break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            decimal depositAmount;
                                            Bancomat.Client.TopUpBalance(out depositAmount);
                                            account.IncreaseBalance(depositAmount);
                                            Bancomat.Client.ShowBalance(account);
                                            Console.ReadLine();
                                            Console.Clear();
                                            choice = Bancomat.Client.MenuOrExit();
                                            if (choice == 1) continue;
                                            else break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            decimal withdrawalAmount;
                                            Bancomat.Client.WithdrawСash(out withdrawalAmount);
                                            account.DecreaseBalance(withdrawalAmount);
                                            Bancomat.Client.ShowBalance(account);
                                            Console.ReadLine();
                                            Console.Clear();
                                            choice = Bancomat.Client.MenuOrExit();
                                            if (choice == 1) continue;
                                            else break;
                                        }
                                    case 4:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("ВЫХОД");
                                            Thread.Sleep(400);
                                            choice = 2;
                                            break;
                                        }
                                    default:
                                        break;
                                }
                                if (choice == 2) break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }
    }
}


