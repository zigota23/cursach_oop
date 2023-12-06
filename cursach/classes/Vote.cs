using System;


namespace cursach
{
    internal class Vote
    {
        public Guid id {  get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string createAt { get; set; }

        public Vote(Guid id,string title, string description,string createAt) { 
            this.id = id;
            this.title = title;
            this.description = description;
            this.createAt = createAt;
        }
    }
}
