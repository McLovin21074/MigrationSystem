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
            {
                EntryDate = entryDate,
                WasMigrant = wasMigrant,
                Citizenship = citizenship,
                IsHighQualified = isHighQualified,
                IsProgramParticipant = isProgramParticipant
            };

            userService.SetUser(user);
        }
    }
}
