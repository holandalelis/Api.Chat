
namespace chat.Models
{
    public class Message
    {
        public string Name { get; set; }
        public string Body { get; set; }
        public string Date { get; set; }
        public Message(string name, string body, string date)
        {
            Name = name;
            Body = body;
            Date = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}