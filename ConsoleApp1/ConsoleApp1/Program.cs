using System;

public class ShortEmailException : Exception
{
    public ShortEmailException(string message) : base(message)
    {
    }
}

public class NotAnEmailAddressException : Exception
{
    public NotAnEmailAddressException(string message) : base(message)
    {
    }
    
    
}

public class EmailValidator
{
    public bool Validate(string email)
    {
        if (email.Length < 10)
        {
            throw new ShortEmailException("Email address is too short.");
        }

        if (!email.EndsWith("@mail.com"))
        {
            throw new NotAnEmailAddressException("Not a valid email address.");
        }

        return true;
    }
}

public class Program
{
    public static void Main()
    {
        EmailValidator validator = new EmailValidator(); 

        try
        {
            string email = "ali.aliyev@mail.com";
            bool isValid = validator.Validate(email);
            Console.WriteLine("Email is valid: " + isValid);
        }
        catch (ShortEmailException ex)
        {
            Console.WriteLine("ShortEmailException: " + ex.Message);
        }
        catch (NotAnEmailAddressException ex)
        {
            Console.WriteLine("NotAnEmailAddressException: " + ex.Message);
        }
    }
}