namespace StackOverFlowPost
{
    public class Post
    {
        public int UpVotes { get; private set; }
        public int DownVotes { get; private set; }
        public string Description { get; private set; }
        public DateTime CreationTime { get; }

        public Post(string description)
        {
            CreationTime = DateTime.Now;
            Description = description;
            UpVotes = 0;
            DownVotes = 0;
        }

        public void UpVote() => UpVotes++;
        public void DownVote() => DownVotes++;
        public int GetVotes() => UpVotes - DownVotes;
    }
}