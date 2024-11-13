namespace MigrationSystem.Model
{
    internal class User
    {
        public DateTime EntryDate { get; set; }
        public string Citizenship { get; set; }
        public bool IsMigrant { get; set; }
        public bool IsHighQualified { get; set; }
        public bool IsInProgram { get; set; }

    }
}
