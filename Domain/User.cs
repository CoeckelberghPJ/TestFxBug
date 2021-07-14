namespace Domain
{
    public class User
    {
        public static User Create(string lastName, string firstName)
        {
            return new User
            {
                LastName = lastName,
                FirstName = firstName
            };
        }

        public User(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public User()
        {
        }

        public string LastName { get; private set; }

        public string FirstName { get; private set; }
    }
}
