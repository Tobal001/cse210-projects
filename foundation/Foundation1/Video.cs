using System.Runtime.CompilerServices;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
        
    }

    public void addComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string GetDisplayText()
    {
        string displayText = $"Title: {_title}\nChannel: {_author}\nVideo Length: {_length} seconds\nComments:\n";

        foreach (Comment comment in _comments)
        {
            displayText += comment.ToString() + "\n";          
        }

        return displayText;
    }

}