namespace _06_Enums_and_ExtensionMethod;

public class InvalidValutaException : Exception
{
    public InvalidValutaException()
    {
    }

    public InvalidValutaException(string message) 
        : base(message)
    {
    }

    public InvalidValutaException(string message, Exception inner) 
        : base(message, inner)
    {
    }

}
