using MigrationSystem.Model;

namespace MigrationSystem.Services
{
    public class UserService
    {
        private User currentUser;

        public void SetUser(User user)
        {
            currentUser = user;
        }

        public User GetUser()
        {
            return currentUser;
        }
    }
}