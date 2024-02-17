using System;

class Program
{
    static void Main(string[] args)
    {
        Video[] _videos = new Video[4];

        _videos[0] = new Video("EmmaCruises", "7 Days In The Most Controversial BALCONY Cabin at Sea", 881);
        _videos[0].AddComment("maryg4551", "Everything you described about this infinite verandah cabin was spot on!  We loved the Edge...the decor, the size, the food, Eden, the entertainment, etc.,  but I like having an ACTUAL balcony");
        _videos[0].AddComment("carolfinnis6152", "An interesting concept but I think I prefer the standard balcony, thanks for showing us!");
        _videos[0].AddComment("TheRadical42", "Hooray for Captain Hudson! What a cute mascot!");

        _videos[1] = new Video("ShawnaEdwardsMusic", "RISEN - New Easter song by Shawna Edwards", 241);
        _videos[1].AddComment("teresalittejohn1021", "Beautiful!!!!!  The REAL STORY of Jesus!  I love it.  You don't hear songs like these anymore, sadly.");
        _videos[1].AddComment("ruthhalima", "Indeed Jesus died n was risen to set the captives free..... Nice melody and To God be the glory.");
        _videos[1].AddComment("thecreativebudgeter", "There just are no words....");
        
        _videos[2] = new Video("KaraandNate", "We Slept in the World's Most Expensive Underwater Hotel", 1510);
        _videos[2].AddComment("Supuntharindu168", "I was the survey engineer for making this masterpiece back in 2018. Really happy to see you there");
        _videos[2].AddComment("jennclack", "As much as I’m happy that you’re taking care of yourself by taking time off, I’m so happy to see a new video! I’ve missed y’all! Thanks for another fun video.");
        _videos[2].AddComment("aliciavandama2058", "Your video quality keeps getting better. Thank you for making your fans feel like family!");

        _videos[3] = new Video("WildWomenExpeditions", "The Camino de Santiago Hiking Adventure", 61);
        _videos[3].AddComment("shannononeil590", "This was such an amazing trip");
        _videos[3].AddComment("LiveLifeLori", "This is on my list! Waiting for you to post a 2024 date :)");
        _videos[3].AddComment("edetsan", "What a great adventure!!!");

        for(int i = 0; i < _videos.Length ; i++)
        {
            Console.WriteLine();
            _videos[i].DisplayVideoInfo();
            _videos[i].DisplayVideoComments();
        }
    }
}