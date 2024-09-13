namespace Program
{
    public interface IValidator
    {
        public bool isValid(Transaction transaction, decimal solde);
    }
}