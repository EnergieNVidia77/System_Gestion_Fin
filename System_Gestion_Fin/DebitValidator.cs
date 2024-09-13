namespace Program
{
    public class DebitValidator : IValidator
    {
        private const decimal MIN_SOLDE = -5000; 
        public bool IsValid(Transaction transaction, decimal solde)
        {
            if(transaction.TypeTransaction == TypeTransaction.Debit && solde - transaction.Montant < MIN_SOLDE)
            {
                Console.WriteLine("Error: Un solde ne peut être en dessous de -5000");
                return false;
            }
            return true;
        }
    }
}