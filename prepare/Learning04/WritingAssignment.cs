public class WritingAssignment : Assignment
{
    private string _title;

    
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        // specificial variables to the WritingAssignment class
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}