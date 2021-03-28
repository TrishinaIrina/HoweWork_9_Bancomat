using System;

namespace HoweWork_9_Bancomat.Bancomat
{
    public class Client
    {
        public static void StartMenu()
        {
            Console.WriteLine("Вас приветствует приложение \"Банкомат\"");
            Console.WriteLine("****************************************");
            Console.WriteLine("1. Открыть счет");
            Console.WriteLine("2. Авторизоваться");
            Console.WriteLine();
            Console.Write("выберите действие: ");
        }

        public static int UserChoice1()
        {
            int enter = int.Parse(Console.ReadLine());
            if (enter > 0 && enter < 3) return enter;
            else
            {
                Console.WriteLine("Ошибка! Нераспознанный пункт меню. Попробуйте еще раз");
                return 0;
            }
        }

        public static void Menu()
        {
            Console.WriteLine("1. Вывести на экран остаток на счету");
            Console.WriteLine("2. Пополнение счета");
            Console.WriteLine("3. Снятие наличных");
            Console.WriteLine("4. Выход");
            Console.WriteLine("****************************************");
            Console.WriteLine();
            Console.Write("выберите действие: ");
        }

        
        public static int UserChoice2()
        {
            int enter = int.Parse(Console.ReadLine());
            if (enter > 0 && enter < 5) return enter;
            else
            {
                Console.WriteLine("Ошибка! Нераспознанный пункт меню. Попробуйте еще раз");
                return 0;
            }
        }

        public static Account Registration()
        {
            Account account = new Account();
            Console.Write("Фамилия: ");
            account.lastName = Console.ReadLine();

            Console.Write("Имя: ");
            account.firstName = Console.ReadLine();

            Console.Write("Отчество: ");
            account.patronymic = Console.ReadLine();

            Console.Write("Дата рождения: ");
            account.dateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Сумма для пополнения счета: ");
            account.balance = Convert.ToDecimal(Console.ReadLine());

            return account;
        }

        public static void ShowRegestrationInfo(Account account)
        {
            Console.Clear();
            Console.WriteLine(account.firstName + ' ' + account.patronymic + ", " + "поздравляем, счет открыт!");
            Console.WriteLine("номер Вашей карточки (счета): " + account.cardNumber);
            Console.WriteLine("пароль: " + account.password);
            Console.WriteLine("текущий баланс счета: " + account.balance);
        }

        public static void EnterCardNumber(out string cardNumber)
        {
            Console.WriteLine("Введите номер счета (карты): ");
            cardNumber = Console.ReadLine();
        }

        public static void EnterPassword(out int password)
        {
            Console.Write("Пароль: ");
            password = int.Parse(Console.ReadLine());
        }

        public static void ShowBalance(Account account)
        {
            Console.WriteLine("текущий баланс: " + account.balance);
        }

        public static void TopUpBalance(out decimal depositAmount)
        {
            Console.Write("сумма для пополнения: ");
            depositAmount = decimal.Parse(Console.ReadLine());
        }

        public static void WithdrawСash(out decimal withdrawalAmount)
        {
            Console.Write("сумма для снятия: ");
            withdrawalAmount = decimal.Parse(Console.ReadLine());
        }

        public static int MenuOrExit()
        {
            Console.WriteLine("1. Вернуться в меню");
            Console.WriteLine("2. Выход");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1 || choice == 2) return choice;
            else
            {
                Console.WriteLine("нераспознанное значение пункта меню!");
                return 0;
            }
        }
    }
}
