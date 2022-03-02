namespace StackOverFlowPost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myPost = new Post("This is my new post!");
            
            myPost.UpVote();
            myPost.UpVote();
            myPost.UpVote();
            myPost.UpVote();
            
            myPost.DownVote();
            myPost.DownVote();
            myPost.DownVote();
            myPost.DownVote();
            myPost.DownVote();

            System.Console.WriteLine( myPost.GetVotes() );
        }

    }
}
