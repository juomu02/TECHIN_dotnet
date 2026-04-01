namespace Products
{
    public class NonPositiveValueException(string reason) : Exception(reason)
    {
        
    }
}