public class Comment
{
    public int CommentId { get; set; }
    public string Contents { get; set; }
    public string Author { get; set; }
    public Comment(int commentId, string contents, string author)
    {
        CommentId = commentId;
        Contents = contents;
        Author = author;
    }

    public string GetString()
    {
        string newString = 
        $"""
        
        {Author}
        -----------------------
        {Contents}
        -----------------------
        """;
        return newString; 
    }
}