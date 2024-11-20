using MigrationSystem.Model;

namespace MigrationSystem.Repositories
{
    public class RulesRepository
    {
        private List<IRule> rules;

        public RulesRepository()
        {
            rules = new List<IRule>
            {
                new RegistrationRule()
            };
        }

        public List<IRule> GetRules()
        {
            return rules;
        }
    }
}
