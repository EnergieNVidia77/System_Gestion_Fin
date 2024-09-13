namespace Program
{
    public class CreditValidator : IValidator
    {
        public const decimal MAX_OP = 10000;

        public bool IsValid(Transaction transaction, decimal solde)
        {
            if(transaction.TypeTransaction == TypeTransaction.Credit && transaction.Montant > MAX_OP)
            {
                Console.WriteLine("Error: une transaction de crédit à un plafond de 10 000");
                return false;
            }
            return true;
        }
    }
}