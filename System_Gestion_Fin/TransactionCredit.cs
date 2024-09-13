namespace Program
{
    public class TransactionCredit : Transaction
    {
        public TransactionCredit(decimal montant, string description) : base(montant, TypeTransaction.Credit, description) { }

        public override decimal appliquer(decimal solde)
        {
            return solde + Montant;
        }
    }
}