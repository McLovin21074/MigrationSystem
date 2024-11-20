namespace MigrationSystem.Model
{
    public class RoadMapPoint
    {
        public string Document { get; private set; }
        public string Pipeline { get; private set; }
        public string Deadline { get; private set; }
        public RoadMapPoint(string document, string pipeline, string deadline)
        {
            Document = document;
            Pipeline = pipeline;
            Deadline = deadline;
        }

        public override string ToString()
        {
            return $"Что получить: {Document}{Environment.NewLine}Что сделать: {Pipeline}{Environment.NewLine}Крайняя дата получения: {Deadline}{Environment.NewLine}";
        }
    }
    
}
