namespace MigrationSystem.Model
{
    public class User
    {
        public DateTime EntryDate { get; set; }
        public bool WasMigrant { get; set; }
        public string? Citizenship { get; set; }
        public bool IsHighQualified { get; set; }
        public bool IsProgramParticipant { get; set; }
    }
}
