namespace IT_ELECTIVE_2_BSIT312E_PREFINAL_EXAM_Lastname_FirstName.Models
{
    public static class ExamRepository
    {
        public static List<ExamQuestion> Questions = new List<ExamQuestion>
        {
            new ExamQuestion
            {
                Id = 1,
                Question = "What is the main problem solved by using a database instead of an in-memory collection?",
                Options = new List<string>{ "A. It makes C# code shorter", "B. It prevents the application from restarting", "C. It allows data to persist after the application stops", "D. It removes the need for MVC" },
                SelectedAnswer = "C. It allows data to persist after the application stops",
                Explanation = "Databases provide persistent storage, retaining data after the process ends."
            },
            new ExamQuestion
            {
                Id = 2,
                Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                Options = new List<string>{ "A. Code-First", "B. Database-First", "C. Model-First", "D. Controller-First" },
                SelectedAnswer = "B. Database-First",
                Explanation = "Database-First approach generates EF Core entity classes and DbContext from an existing database schema."
            },
        };
    }
}