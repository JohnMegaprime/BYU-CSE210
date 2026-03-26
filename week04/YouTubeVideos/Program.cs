using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("I Played Skyrim in VR Until I Physically Passed Out", "GlitchWalker", 1423);

        video1.AddComment("VR_Junkie99", "Bro really risked his actual life for a sweet roll. Respect.");
        video1.AddComment("SkyrimFanatic01", "The moment you tried to pet the dragon is where I completely lost it.");
        video1.AddComment("CozyGamerGirl", "Please drink some water before your next video, we need you alive!");

        Video video2 = new Video("The Greatest Hidden Gem on Steam Right Now (Under $5)", "SarahPlayz", 645);

        video2.AddComment("IndieLover22","I bought this immediately after watching, and I can confirm it's worth way more than $5. Thanks for the recommendation!");
        video2.AddComment("BacklogChampion","I've had this in my wishlist for three years, guess it's finally time to pull the trigger.");
        video2.AddComment("PixelArtEnthusiast","The art style alone is worth the price of admission. Amazing find.");
        
        Video video3 = new Video("Why We All Stopped Playing Competitive Shooters", "MidnightController", 2108);

        video3.AddComment("TiredGamerDad","This hit way too close to home. I just want to relax after work now, not get yelled at by a 12-year-old.");
        video3.AddComment("FPS_Veteran","SBMM completely ruined the casual experience. You nailed exactly how my friend group feels.");
        video3.AddComment("SoloQSurvivor","I switched to single-player story games last year and my stress levels have literally plummeted.");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoText();
            Console.WriteLine();
        }

    }
}