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
            new ExamQuestion
            {
                Id = 3,
                Question = "What is the primary purpose of Entity Framework Core?",
                Options = new List<string>{ "A. To create HTML pages automatically", "B. To replace the MVC Controller", "C. To map objects in code to relational database data", "D. To replace the C# compiler" },
                SelectedAnswer = "C. To map objects in code to relational database data",
                Explanation = "EF Core is an Object-Relational Mapper (ORM) that maps C# domain objects to relational database tables."
            },
            new ExamQuestion
            {
                Id = 4,
                Question = "Which EF Core component is primarily responsible for communicating with the database?",
                Options = new List<string>{ "A. DbContext", "B. DbSetView", "C. ControllerContext", "D. RazorContext" },
                SelectedAnswer = "A. DbContext",
                Explanation = "DbContext coordinates EF Core functionality and acts as the primary class for interacting with the database."
            },
        };
    }
}