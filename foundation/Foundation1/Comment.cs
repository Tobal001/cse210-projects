public class Comment 
{
    string _userName;

    string _comment;

    public Comment(string username, string comment)
    {
        _userName = username;
        _comment = comment;
    }

    public override string ToString()
    {
        return $"Username: {_userName}\n{_comment}";
    }
}