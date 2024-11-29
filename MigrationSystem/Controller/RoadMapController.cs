using MigrationSystem.Model;
using MigrationSystem.Repositories;
using MigrationSystem.Services;


namespace MigrationSystem.Controller
{
    public class RoadMapController
    {
        private readonly RulesRepository rulesRepository;
        private readonly UserService userService;

        public RoadMapController(RulesRepository rulesRepository, UserService userService)
        {
            this.rulesRepository = rulesRepository;
            this.userService = userService;
        }

        public string GetRoadMap()
        {
            var rules = rulesRepository.GetRules();
            var user = userService.GetUser();
            var roadMap = new RoadMap(rules);
            roadMap.Generate(user);


            return roadMap.GetMap();
        }
    }
}