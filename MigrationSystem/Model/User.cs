namespace MigrationSystem.Model
{
    internal class User
    {
        public DateTime EntryDate { get; private set; }
        public string Citizenship { get; private set; }
        public bool IsMigrant { get; private set; }
        public bool IsHighQualified { get; private set; }
        public bool IsInProgram { get; private set; }

    }
}
