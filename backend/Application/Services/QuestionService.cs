using InterviewBetter.Domain.Models;

namespace InterviewBetter.Application.Services;

public interface IQuestionService
{
    List<Question> GetAll();
    List<Question> GetByCategory(string category);
    Question? GetById(int id);
}

public class QuestionService : IQuestionService
{
    private readonly List<Question> _questions = new()
    {
        new Question { Id = 1, Category = "Behavioral", Text = "Tell me about a time you faced a significant challenge.", Difficulty = "Medium", Tags = new() { "leadership", "problem-solving" } },
        new Question { Id = 2, Category = "Behavioral", Text = "Describe a situation where you had to work with a difficult teammate.", Difficulty = "Medium", Tags = new() { "teamwork" } },
        new Question { Id = 3, Category = "Technical", Text = "Explain the difference between a process and a thread.", Difficulty = "Easy", Tags = new() { "os", "concurrency" } },
        new Question { Id = 4, Category = "Technical", Text = "How would you optimize a slow database query?", Difficulty = "Hard", Tags = new() { "databases", "performance" } },
        new Question { Id = 5, Category = "System Design", Text = "Design a URL shortener service.", Difficulty = "Hard", Tags = new() { "scalability", "design" } }
    };

    public List<Question> GetAll() => _questions;
    public List<Question> GetByCategory(string category) => _questions.Where(q => q.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
    public Question? GetById(int id) => _questions.FirstOrDefault(q => q.Id == id);
}
