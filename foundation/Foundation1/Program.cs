using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("5-Minute Morning Workout", "FitnessWithFrank", 312);
        Comment vid1Comment1 = new Comment("HealthyHeather123", "Tried this today, and wow, I feel energized! Thanks for keeping it simple!");
        Comment vid1Comment2 = new Comment("MorningGrindMike", "Perfect routine for those busy mornings. Loving it!");
        Comment vid1Comment3 = new Comment("LazyButTrying", "I made it through 3 minutes... progress, right?");
        video1.addComment(vid1Comment1);
        video1.addComment(vid1Comment2);
        video1.addComment(vid1Comment3);

        Video video2 = new Video("10 Hidden Features of iOS 17 You Didn't Know About", "TechBuzzDaily", 645);
        Comment vid2Comment1 = new Comment("AppGuru34", "The 3rd feature blew my mind. Didn’t even know that existed!");
        Comment vid2Comment2 = new Comment("PixelPeeker", "Good stuff, but wish you’d explained the shortcuts in more detail.");
        Comment vid2Comment3 = new Comment("SamSavesTech", "Update's got some neat tricks! Thanks for this!");
        video2.addComment(vid2Comment1);
        video2.addComment(vid2Comment2);
        video2.addComment(vid2Comment3);

        Video video3 = new Video("How to Make the Best Spaghetti Carbonara", "ChefInTheCity", 498);
        Comment vid3Comment1 = new Comment("FoodieFanatic", "Tried this for dinner, and my family LOVED it! Super easy to follow.");
        Comment vid3Comment2 = new Comment("PastaLover88", "Never thought to use pecorino instead of parmesan, game-changer!");
        Comment vid3Comment3 = new Comment("CookingIsTherapy", "Delicious recipe but I overcooked the eggs... will try again!");
        video3.addComment(vid3Comment1);
        video3.addComment(vid3Comment2);
        video3.addComment(vid3Comment3);

        Console.WriteLine(video1.GetDisplayText());
        Console.WriteLine(video2.GetDisplayText());
        Console.WriteLine(video3.GetDisplayText());
        



    }
}