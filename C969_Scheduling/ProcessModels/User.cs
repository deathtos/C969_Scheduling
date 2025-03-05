namespace C969_Scheduling.ProcessModels
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }

        public User() { }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
