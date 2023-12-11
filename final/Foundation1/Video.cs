class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthSeconds { get; set; }
    public List<Comment> Comments { get; } = new List<Comment>();

    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment { CommenterName = commenterName, CommentText = commentText };
        Comments.Add(comment);
    }

    public int GetNumComments()
    {
        return Comments.Count;
    }
}