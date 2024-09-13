namespace Program
{
    public interface IValidator
    {
        public bool IsValid(Transaction transaction, decimal solde);
    }
}