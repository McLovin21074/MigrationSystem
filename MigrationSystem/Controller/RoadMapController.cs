﻿using MigrationSystem.Model;
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

        public RoadMap GetRoadMap()
        {
            var rules = rulesRepository.GetRules();
            var user = userService.GetUser();
            var roadMap = new RoadMap();

            foreach (var rule in rules)
            {
                if (rule.Check(user))
                {
                    var point = rule.CreateRoadMapPoint(user);
                    roadMap.AddPoint(point);
                }
            }

            return roadMap;
        }
    }
}
