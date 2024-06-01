public class Video
{
    public int VideoId { get; set; }
    public string Title { get; set; }
    public string Channel { get; set; }
    public string Length { get; set; } 
    public List<Comment> CommentList { get; set; }
    public Video(int videoId, string title, string channel, string length, List<Comment> commentList)
    {
        VideoId = videoId;
        Title = title;
        Channel = channel;
        Length = length;
        CommentList = commentList;
    }

    public string displayVideo()
    {
        var newString =
        $"""
        {Title}
        ------------
        {Channel} - {Length}
        ===========================================
        """;
        foreach (Comment comment in CommentList)
        {
            newString += comment.GetString();
        }
        return newString;
    }
}