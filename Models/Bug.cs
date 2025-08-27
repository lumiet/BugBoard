namespace BugBoard.Models
{
    public enum Severity { Low, Medium, High, Critical }

    public class Bug
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public Severity Severity { get; set; }
        public bool IsOpen { get; set; }
        public string? Owner { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}