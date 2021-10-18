using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace socialsleuthsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Title
            Console.Title = ("SocialSleuthSharp");

            // Background & Foreground Color
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            // Console.Clear();

            // ASCII SocialSleuthSharp
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(
                FiggleFonts.Slant.Render("SocialSleuthSharp"));
            Console.ForegroundColor = ConsoleColor.White;

            // ASCII Version
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(
                FiggleFonts.Slant.Render("v1.2"));
            Console.ForegroundColor = ConsoleColor.White;

            // Credits
            Console.WriteLine("Created by Official B#001 on Discord" + "\n");

            // Version
            // Console.Write("v1.0 | UP TO DATE \n \n");

            // Welcome Msg
            Console.WriteLine("Welcome to SocialSleuthSharp! Please enter the Username of the person you would like to find below! \n");
            
    
            // Username
            Console.Write("Username of the subject: ");
            
            // User Input for putting user in links
            string search = Console.ReadLine();

            // Links
            Console.WriteLine("Here are some links to try: \n");

            Console.WriteLine("https://twitter.com/" + search);

            Console.WriteLine("https://www.facebook.com/" + search);

            Console.WriteLine("https://za.linkedin.com/in/" + search);

            Console.WriteLine("https://www.snapchat.com/app/" + search);

            Console.WriteLine("https://www.instagram.com/" + search);

            Console.WriteLine("https://www.tiktok.com/@" + search);

            Console.WriteLine("https://www.pinterest.com/" + search);

            Console.WriteLine("https://www.tumblr.com/blog/view/" + search);

            Console.WriteLine("http://subrock.rocks/channel_2?n=" + search);

            Console.WriteLine("http://subrock.rocks/user/" + search);

            Console.WriteLine("https://www.reddit.com/user/" + search);

            Console.WriteLine("https://github.com/" + search);

            Console.WriteLine("https://www.flickr.com/photos/" + search);

            Console.WriteLine("https://soundcloud.com/" + search);

            Console.WriteLine("https://t.me/" + search);

            Console.WriteLine("https://www.bitview.net/profile.php?user=" + search);

            Console.WriteLine("https://www.vidlii.com/user/" + search);

            Console.WriteLine("https://www.guilded.gg//" + search + " THIS IS FOR SERVERS ONLY");

            Console.WriteLine("https://www.guilded.gg/u/" + search + " THIS IS FOR PROFIES (ONLY VANITY URL SUPPORTED)");

            Console.WriteLine("https://bwitter.me/" + search);

            Console.WriteLine("https://youtube.com/user/" + search + " VANITY ONLY");

            Console.WriteLine("https://pastebin.com/u/" + search);

            Console.WriteLine("https://codepen.io/" + search);

            Console.WriteLine("https://replit.com/@" + search);

            Console.WriteLine("https://" + search + ".carrd.co");

            Console.WriteLine("https://www.crunchyroll.com/user/" + search + " CLASSIC ONLY");

            Console.WriteLine("https://scratch.mit.edu/users/" + search);

            Console.WriteLine("https://discords.com/bio/p/" + search);

            Console.WriteLine("https://www.twitch.tv/" + search);

            Console.WriteLine("https://" + search + ".newgrounds.com");

            Console.WriteLine("https://archive.org/details/@" + search);

            Console.WriteLine("https://" + search + ".github.io");

            Console.WriteLine("\n");

            Console.WriteLine("Press enter to exit.");

            // End
            Console.ReadLine();
        }
    }
}
