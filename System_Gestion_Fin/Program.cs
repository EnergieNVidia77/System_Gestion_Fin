using System;
using System.Diagnostics;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            TransactionService transactionService = new TransactionService();
            transactionService.AjouterValidator(new DebitValidator());
            transactionService.AjouterValidator(new CreditValidator());

            transactionService.AjouterTransaction(new TransactionCredit(12000, "Transaction A"));
            transactionService.AjouterTransaction(new TransactionCredit(8000, "Transaction B"));
            transactionService.AjouterTransaction(new TransactionDebit(6000, "Transaction C"));
            transactionService.AjouterTransaction(new TransactionDebit(15000, "Transaction D"));
        }
    }
}