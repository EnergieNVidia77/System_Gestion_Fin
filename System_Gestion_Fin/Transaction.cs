namespace Program
{
    public abstract class Transaction
    {
        public DateTime Date { get; private set; }
        public decimal Montant { get; private set; }
        public TypeTransaction TypeTransaction { get; private set; }
        public string Description { get; private set; }

        protected Transaction(decimal montant, TypeTransaction typeTransaction, string description)
        {
            Date = DateTime.Now;
            Montant = montant;
            TypeTransaction = typeTransaction;
            Description = description;
        }

        public abstract decimal appliquer(decimal solde);
    }
}