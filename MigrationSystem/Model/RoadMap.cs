using System.Text;


namespace MigrationSystem.Model
{
    public class RoadMap
    {
        public List<RoadMapPoint> Points { get; private set; } = new List<RoadMapPoint>();

        public void AddPoint(RoadMapPoint point)
        {
            Points.Add(point);
        }

        public string GetMap()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Points.Count; i++)
            {
                var point = Points[i];
                sb.AppendLine($"Пункт {i + 1}:");
                sb.AppendLine(point.ToString());
                sb.AppendLine(new string('-', 40));
            }
            return sb.ToString();
        }
    }
}
