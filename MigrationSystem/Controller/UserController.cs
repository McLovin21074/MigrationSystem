using MigrationSystem.Model;

namespace MigrationSystem.Controller
{
    internal class UserController
    {
        public void EntryDetails(DateTime entryDate, bool isMigrant, bool isInProgram,
            string citizenship, bool isHighQualified)
        {
            var user = new User
            {
                EntryDate = entryDate,
                IsMigrant = isMigrant,
                IsInProgram = isInProgram,
                Citizenship = citizenship,
                IsHighQualified = isHighQualified
            };

            UserServ.SetUser(user);
        }
    }
}
