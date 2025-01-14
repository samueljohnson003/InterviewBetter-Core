namespace InterviewBetter.Domain.Models;

public class Question
{
    public int Id { get; set; }
    public string Category { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public string Difficulty { get; set; } = "Medium";
    public List<string> Tags { get; set; } = new();
    public string? SampleAnswer { get; set; }
}

public class InterviewSession
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Category { get; set; } = string.Empty;
    public DateTime StartedAt { get; set; } = DateTime.UtcNow;
    public List<SessionAnswer> Answers { get; set; } = new();
    public string Status { get; set; } = "InProgress";
}

public class SessionAnswer
{
    public int QuestionId { get; set; }
    public string Response { get; set; } = string.Empty;
    public int? Score { get; set; }
    public string? Feedback { get; set; }
}
