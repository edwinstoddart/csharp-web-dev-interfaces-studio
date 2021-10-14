using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            Dictionary<string, string> CDData = new Dictionary<string, string>
            {
                {"Name", "Burgz"},
                {"Length", "03:55"},
                {"Artist", "Ken Ashcorp"},
                {"Description", "It's a song about burgers and maybe relationships who knoooows???"},
                {"Lyrics", "Well it was just\n"
                + "5 guys on a night out (Oh)\n"
                + "Looks like they could box your lights out\n"
                + "Insatiable hunger\n"
                + "Looking for the one they could take home right now\n"
                + "[...]"}
            };
            Dictionary<string, string> DVDData = new Dictionary<string, string>
            {
                {"Name", "Bee Movie" },
                {"Length", "01:31:00" },
                {"Genre", "Terrible" },
                {"Description", "There are better uses of your time. This is not bad like The Room, it's just unenjoyable." },
                {"Subtitles", "According to all known laws of aviation,\n"
                + "there is no way a bee should be able to fly.\n"
                + "Its wings are too small to get\n"
                + "its fat little body off the ground.\n"
                + "The bee, of course, flies anyway\n"
                + "because bees don't care what humans think is impossible.\n"
                + "[...]" }
            };

            CD MyCD = new CD(CDData, 6);
            DVD MyDVD = new DVD(DVDData, 6);

            // TODO: Call each CD and DVD method to verify that they work as expected.
            MyCD.SpinDisk();
            Console.WriteLine(MyCD.ToString());
            Console.WriteLine(MyCD.ReadData("Artist"));
            Console.WriteLine(MyCD.AddData("Genre", "It's a funny song and maybe a bit poppy who knoooows???"));
            Console.WriteLine(MyCD.OverwriteData("Length", "Repeated 2 Times Length", "07:50"));
            Console.WriteLine(MyCD.ToString());
            MyCD.EjectDisk();

            Console.WriteLine("\n----------\n");

            MyDVD.SpinDisk();
            Console.WriteLine(MyDVD.ToString());
            Console.WriteLine(MyDVD.ReadData("Genre"));
            Console.WriteLine(MyDVD.AddData("User Review", "This movie turned my son into a newt... He didn't get better."));
            Console.WriteLine(MyDVD.OverwriteData("Genra", "Genre", "It was(n't) okay."));
            Console.WriteLine(MyDVD.ToString());
            MyDVD.EjectDisk();
        }
    }
}
