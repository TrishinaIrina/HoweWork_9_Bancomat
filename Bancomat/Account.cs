using System;


namespace HoweWork_9_Bancomat.Bancomat
{
    public class Account
    {
        Random rnd = new Random();
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string patronymic { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string cardNumber { get; }
        public int password { get; set; }
        public decimal balance { get; set; }
        public Account()
        {
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();
            cardNumber += rnd.Next(0, 9).ToString();

            password = rnd.Next(1000, 9999);
            balance = 0;
        }

        public void IncreaseBalance(decimal depositAmount)
        {
            balance += depositAmount;
        }

        public void DecreaseBalance(decimal withdrawalAmount)
        {
            if (withdrawalAmount <= balance)
            {
                balance -= withdrawalAmount;
            }
            else Console.WriteLine("на счету недостаточно средств");
        }


    }
}
