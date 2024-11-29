namespace MigrationSystem.Model
{
    public interface IRule
    {
        public bool Check(User user);
        public RoadMapPoint CreateRoadMapPoint(User user);
    }
}