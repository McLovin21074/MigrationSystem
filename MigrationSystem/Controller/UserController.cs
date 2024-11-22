using MigrationSystem.Model;
using MigrationSystem.Services;

namespace MigrationSystem.Controller
{
    public class UserController
    {
        private readonly UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        public void EnterDetails(DateTime entryDate, bool wasMigrant, string citizenship, bool isHighQualified, bool isProgramParticipant)
        {
            var user = new User
            (
                entryDate,
                wasMigrant,
                citizenship,
                isHighQualified,
                isProgramParticipant
            );

            userService.SetUser(user);
        }
    }
}
