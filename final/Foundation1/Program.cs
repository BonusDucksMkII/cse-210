using System;

class Program
{
    static void Main(string[] args)
    {
        var CommentList1 = new List<Comment>
        {
            new(1, "Bro, can't believe this guy got OWNED by a fish! 🤮", "xXGoliathXx_404"),
            new(2, "Good video! One thing, fish can't slap people? Like, I don't wanna hate, but...", "buzzkiller26"),
            new(3, "hey pls subsrivb o my chanel 4 more cool videos liek thiss on", "michael.roberts.2006")
        };

        var CommentList2 = new List<Comment>
        {
            new(1, "BEts gaem 2019", "superminecraftplayer"),
            new(2, "Like and subscribe!", "minecraftfan1"),
            new(3, "This comment has been removed due to community violations", "deleted-user")
        };

        var CommentList3 = new List<Comment>
        {
            new(1, "Thanks for posting this! I love the song at 11:56; good memories.", "GladysGladness"),
            new(2, "I miss the days of listening to Gershwin with my mom. Miss you, mom", "1957joel"),
            new(3, "Nice mix man thanks", "quickquotesquill20")
        };
 
        var VideoList = new List<Video>
        {
            new(1, "Big Fish Slaps Man WITH HIS OWN HANDS!!??", "Real Fishing", "6:00", CommentList1),
            new(2, "Minecraft Playthrough Pt. 1 [Overt Corporate Shilling]", "minecraftfan1", "12:56", CommentList2),
            new(3, "Quiet Jazz to Eat your Steak To [2019 MIX]", "CarlosGonzalezVEVO", "1:24:26", CommentList3)
        };

        foreach (Video video in VideoList)
        {
            Console.WriteLine(video.displayVideo());
        }
    }
}