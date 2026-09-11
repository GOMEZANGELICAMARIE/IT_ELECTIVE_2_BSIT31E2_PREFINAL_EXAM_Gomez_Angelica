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
            new ExamQuestion
            {
                Id = 5,
                Question = "What does the following command primarily do? dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                Options = new List<string>{ "A. Deletes the database", "B. Creates a new MVC project", "C. Generates EF Core models and a DbContext from an existing database", "D. Starts the MVC application" },
                SelectedAnswer = "C. Generates EF Core models and a DbContext from an existing database",
                Explanation = "The scaffold command reverse-engineers an existing database to generate entity model classes and a DbContext."
            },
            new ExamQuestion
            {
                Id = 6,
                Question = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                Options = new List<string>{ "A. Program.cs only", "B. appsettings.json", "C. Index.cshtml", "D. Student.cs" },
                SelectedAnswer = "B. appsettings.json",
                Explanation = "Configuration settings like database connection strings are conventionally kept in appsettings.json."
            },
            new ExamQuestion
            {
                Id = 7,
                Question = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                Options = new List<string>{ "A. One-to-One", "B. One-to-Many", "C. Many-to-Many", "D. Many-to-One only" },
                SelectedAnswer = "B. One-to-Many",
                Explanation = "A parent entity (Section) having multiple child entities (Students) defines a One-to-Many relationship."
            },
            new ExamQuestion
            {
                Id = 8,
                Question = "In the following example, what is SectionId? public int SectionId { get; set; } public Section Section { get; set; }",
                Options = new List<string>{ "A. Primary key of Student", "B. Foreign key referencing Section", "C. Navigation property", "D. Database connection string" },
                SelectedAnswer = "B. Foreign key referencing Section",
                Explanation = "SectionId acts as the foreign key property pointing to the primary key of the related Section entity."
            },
            new ExamQuestion
            {
                Id = 9,
                Question = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                Options = new List<string>{ "A. It stores the database password", "B. It represents a relationship to another entity", "C. It creates a new database", "D. It validates the student's name" },
                SelectedAnswer = "B. It represents a relationship to another entity",
                Explanation = "Navigation properties allow navigation from an entity to its related objects in code."
            },
            new ExamQuestion
            {
                Id = 10,
                Question = "What does .Include() generally allow EF Core to do?",
                Options = new List<string>{ "A. Delete the Section table", "B. Load related Section data together with Students", "C. Create a new Student", "D. Validate Student input" },
                SelectedAnswer = "B. Load related Section data together with Students",
                Explanation = "The .Include() extension method specifies related entities to be included in query results (eager loading)."
            },
        };
    }
}