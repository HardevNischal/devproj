using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Tracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Hardev's MP3 Player! This program shows the functionality of the MP3 class.");
            Console.Write("Please enter your Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}");
            
            MP3 mp3 = null;
            do
            {
                Console.WriteLine("Menu for Project 1 - MP3\n---------------");
                Console.WriteLine("1. Create a new MP3 file\n2. Display an MP3 file\n3. End the Program");
                int userChoice = int.Parse(Console.ReadLine());
                if (userChoice == 1)
                {

                    mp3 = new MP3();
                    Console.WriteLine("What is the song title?");
                    mp3.SetSongTitle(Console.ReadLine());
                    Console.WriteLine($"Who is the artist to {mp3.GetSongTitle()}?");
                    mp3.SetArtist(Console.ReadLine());
                    Console.WriteLine("When did the song come out?");
                    mp3.SetReleaseDate(Console.ReadLine());
                    Console.WriteLine("What is the Genre? 0 = Rock, 1 = Pop, 2 = Jazz, 3 = Country, 4 = Classical, 5 = Other ");
                    if (int.TryParse(Console.ReadLine(), out int genreIndex))
                    {
                        mp3.SetGenre(genreIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Setting Genre to 'Other'.");
                        mp3.SetGenre(5); 
                    }
                    Console.WriteLine("What is the download cost?");
                    mp3.SetDownloadCost(decimal.Parse(Console.ReadLine()));
                    Console.WriteLine("What is the file size?");
                    mp3.SetFileSize(double.Parse(Console.ReadLine()));
                    Console.WriteLine("How long is the song?");
                    mp3.SetPlaybackTime(double.Parse(Console.ReadLine()));
                    Console.WriteLine("What is the album photo path?");
                    mp3.SetPhotoJPG(Console.ReadLine());
                    
                }
                else if (userChoice == 2)
                {
                    if (mp3 != null)
                    {
                        Console.WriteLine(mp3.ToString());
                    }
                    else
                    {
                        Console.WriteLine("There has not been an MP3 object created yet");
                    }
                }
                else
                {
                    break;
                }
            } while (true);
        }
    }
}
