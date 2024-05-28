namespace bolao10.api.Services.Interfaces
{
    public interface IEncryptionService
    {
        string Decrypt(string contents);
        string Encrypt(string contents);
    }
}