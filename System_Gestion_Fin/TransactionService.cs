namespace Program
{
    public class TransactionService
    {
        private decimal _solde = 0;
        private readonly List<Transaction> _transactions = new List<Transaction>();
        private readonly List<IValidator> _validators = new List<IValidator>();

        public void AjouterValidator(IValidator validator)
        {
            _validators.Add(validator);
        }

        public void AjouterTransaction(Transaction transaction)
        {
            foreach (var validator in _validators)
            {
                if (!validator.IsValid(transaction, _solde))
                {
                    Console.WriteLine("Transaction refusé : {0}", transaction.Description);
                    return;
                }
            }

            _solde = transaction.appliquer(_solde);
            _transactions.Add(transaction);
            Console.WriteLine("Transaction ajoutée : {0}, nouveau solde : {1}", transaction.Description, _solde);
        }
    }
}