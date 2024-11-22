namespace MigrationSystem.Model
{
    public class User
    {
        public DateTime EntryDate { get; private set; }
        public bool WasMigrant { get; private set; }
        public string? Citizenship { get; private set; }
        public bool IsHighQualified { get; private set; }
        public bool IsInProgram { get; private set; }

        public User(DateTime entryDate, bool wasMigrant, string? citizenship, bool isHighQualified, bool IsInProgram)
        {
            EntryDate = entryDate;
            WasMigrant = wasMigrant;
            Citizenship = citizenship;
            IsHighQualified = isHighQualified;
            IsInProgram = IsInProgram;
        }
    }
}
