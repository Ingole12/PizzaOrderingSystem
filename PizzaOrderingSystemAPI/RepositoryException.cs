namespace PizzaOrderingSystemAPI
{
    public class RepositoryException : Exception
    {
        public RepositoryException(string message, Exception ex) : base(message) { }
    }
}
