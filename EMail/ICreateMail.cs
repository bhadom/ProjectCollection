namespace ProjectCollection
{
    public interface ICreateMail
    {
        void CreateMessage(string sender, string receiver, string subject, string content, string password);
    }
}
