using SQLite;

namespace App1
{
    public class Feed
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }

    }
}
