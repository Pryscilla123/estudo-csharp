using System.Text;

namespace stringBuilder.Entities;

class Post
{
    public DateTime Moment { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public Post()
    {
    }

    public Post(DateTime moment, string title, string content, int likes)
    {
        Moment = moment;
        Title = title;
        Content = content;
        Likes = likes;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void RemoveComment(Comment comment){
        Comments.Remove(comment);
    }

    override public string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(Title).Append(Likes).AppendFormat(" Likes - ").AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss")).AppendLine(Content);
        sb.AppendLine("Comments:");
        foreach(Comment c in Comments){
            sb.AppendLine(c.Text);
        }
        return sb.ToString();
    }
}