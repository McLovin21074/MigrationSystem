namespace MigrationSystem.Model
{
    internal static class UserServ
    {
        private static User user;

        public static void SetUser(User NewUser)
        {
            user = NewUser;
        }

        public static User GetUser() { return user;}
    }
}
