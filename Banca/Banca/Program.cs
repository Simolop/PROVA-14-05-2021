using System;
using System.Linq;

namespace Banca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESERCITAZIONE FINALE - BANCA!");


            Account account1 = new Account(12345, "Intesa San Paolo", 2200, DateTime.Today);

            
            CreditCardMovement movimento1 = new CreditCardMovement(11234, Tipo.MASTERCARD, 1000, new DateTime(2021,5,14));
            CashMovement movimento2 = new CashMovement("Mario Rossi", 100, new DateTime(2020,9,23));
            TransfertMovement movimento3 = new TransfertMovement("BNL", "Intesa San Paolo", 200, DateTime.Today);
            CreditCardMovement movimento4 = new CreditCardMovement(33245, Tipo.VISA, 300, new DateTime(2019,5,4));
            CreditCardMovement movimento5 = new CreditCardMovement(36100, Tipo.OTHER, 1000, DateTime.Today);
            CashMovement movimento6 = new CashMovement("Simona Loperfido", 500, new DateTime(2021, 5, 9));
            TransfertMovement movimento7 = new TransfertMovement("Banca Centrale", "Intesa San Paolo", 400, DateTime.Today);

            Console.WriteLine();
            Console.WriteLine($"Lista movimenti del conto numero: {account1.NumeroConto}");

            if (account1 + movimento1)
               Console.WriteLine($"\n Movimento 1:\n {movimento1.ToString()} \n  Saldo: {account1.Saldo} Euro.");          

            if (account1 + movimento2)
               Console.WriteLine($"\n Movimento 2:\n {movimento2.ToString()} \n  Saldo: {account1.Saldo} Euro.");

            if (account1 - movimento3)
               Console.WriteLine($"\n Movimento 3:\n {movimento3.ToString()} \n  Saldo: {account1.Saldo} Euro.");         

            if (account1 - movimento4)
               Console.WriteLine($"\n Movimento 4:\n {movimento4.ToString()} \n  Saldo: {account1.Saldo} Euro.");

            if (account1 + movimento5)
               Console.WriteLine($"\n Movimento 5:\n {movimento5.ToString()} \n  Saldo: {account1.Saldo} Euro.");

            if (account1 - movimento6)
               Console.WriteLine($"\n Movimento 6:\n {movimento6.ToString()} \n  Saldo: {account1.Saldo} Euro.");

            if (account1 - movimento7)
               Console.WriteLine($"\n Movimento 7:\n {movimento7.ToString()} \n  Saldo: {account1.Saldo} Euro.");






        }
    }
}
