using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowswerApp
{
    class Program //Sample Application to open website link , Ref : youtube.com/  
    {
        class Entry
        {
            public string url;
            public string name;
            public string key;

            public Entry(string newUrl, string newName, string newKey)
            {
                url = newUrl;
                name = newName;
                key = newKey;
            }

        }



        static void Main(string[] args)
        {
            Entry[] entries = new Entry[]
            {
                new Entry("www.facebook.com","Facebook","F"),
                new Entry("www.google.com","Google","G"),
                new Entry("www.youtube.com","Youtube","Y"),
                new Entry("www.hse.ie","Hse","H"),
                new Entry("www.heal.com","Heal","A"), 
                new Entry("www.cure.com","Cure","C"),
                new Entry("safeireland.ie","Safeireland","S"),
                new Entry("healing.com","Healing","C"),
                new Entry("care.com","Care","E"),
                new Entry("well.com","Well", "W"),//  valid links can be adjusted  
            };
            Console.WriteLine("Refrence sample c# App ");
            Console.WriteLine("Simply Write the key and press enter !");
            Console.WriteLine("keys");
            foreach  (Entry entry in entries)
            {
                Console.WriteLine("\t" + entry.key + " - " + entry.name);

            }
            Console.WriteLine("\nYour Key");
            string userInput = Console.ReadLine().ToLower();
            bool foundEntry = false;
            foreach (Entry entry in entries)
            {
                if (userInput == entry.key.ToLower() || userInput == entry.name.ToLower())
                {
                    System.Diagnostics.Process.Start(@"C:\Program Files\Internet Explorer\iexplore.exe", entry.url);
                    foundEntry = true;
                    RestartApp();

                }
            }
            if (foundEntry == false)
            {
                Console.WriteLine("\n no find a valid entry.once again? ");
                Console.WriteLine("\ty - yes");
                Console.WriteLine("\nYour Key?");

                string choice = Console.ReadLine();
                if (choice == "y" || choice == "yes")
                {
                    //Restart app method to reuse or start the app 
                    RestartApp();
                }

            }
             void RestartApp()  // restart app to clear the programs and start from the main method 
            {
                Console.Clear();
                Main(null);
            }


            
            Console.ReadLine();
            
        }
    }
}
