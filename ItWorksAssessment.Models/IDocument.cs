namespace ItWorksAssessment.Models
{
    public interface IDocument
    {
        string Name { get; set; }
        string Content { get; set; }
        void Print();       
    }
}
