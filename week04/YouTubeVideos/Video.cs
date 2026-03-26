
public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name,text);
        _comments.Add(comment);
    }

    public int CommentsNumber()
    {
        int number = _comments.Count();
        return number;
    }

    public void DisplayVideoText()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($" Author: {_author}");
        Console.WriteLine($"Number of comments: {CommentsNumber()} - Length: {_length} seconds");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"\t{comment.DisplayComment()}");
        }
    }


}