namespace IT_ELECTIVE_2_BSIT312E_PREFINAL_EXAM_Lastname_FirstName.Models
{
    public class ExamQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new();
        public string SelectedAnswer { get; set; } = string.Empty;
        public string CorrectAnswer { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
    }
}