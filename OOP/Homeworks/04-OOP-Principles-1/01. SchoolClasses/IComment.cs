namespace _01.SchoolClasses
{
    public interface IComment
    {
        string Comments { get; }

        void AddComment(string comment);
        void DeleteComments();
    }
}
