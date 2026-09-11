namespace IT_ELECTIVE_2_31E1_PREFINAL_EXAM_Mescallado_Judiel_Meguiel.Models
{
    public class ExamItem
    {
        public int Number { get; set; }
        public string Question { get; set; } = string.Empty;
        public string OptionA { get; set; } = string.Empty;
        public string OptionB { get; set; } = string.Empty;
        public string OptionC { get; set; } = string.Empty;
        public string OptionD { get; set; } = string.Empty;
        public string CorrectAnswer { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
    }
}
