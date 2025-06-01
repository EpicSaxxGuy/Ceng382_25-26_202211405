namespace Week6FormApp.Models
{
    public class ClassInformationTable
    {
        public string ClassName { get; set; }
        public int StudentCount { get; set; }
        public string? Description { get; set; }
        public int Id { get; set; } // Will not be shown in table, but used internally
    }
}
