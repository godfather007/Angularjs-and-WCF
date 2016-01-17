namespace MatrimonyServices.Interfaces
{
    public interface ICredentialsValidator
    {
        bool IsValid(user user);
    }
}