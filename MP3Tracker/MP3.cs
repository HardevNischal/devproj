using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Tracker
{
    public class MP3
    {
        //attributes
        private string SongTitle;
        private string Artist;
        private string SongReleaseDate;
        private double PlaybackTime;
        private decimal DownloadCost;
        private double FileSize;
        private string PhotoJPG;
        private Genre Genre;

        //accessors and mutators
        public void SetSongTitle(string songTitle)
        {
            SongTitle = songTitle;
        }
        public void SetArtist(string artist)
        {
            Artist = artist;
        }
        public void SetReleaseDate(string releaseDate)
        {
            SongReleaseDate = releaseDate;
        }
        public void SetPlaybackTime(double playbackTime)
        {
            PlaybackTime = playbackTime;
        }
        public void SetDownloadCost(decimal downloadCost)
        {
            DownloadCost = downloadCost;
        }
        public void SetFileSize(double fileSize)
        {
            FileSize = fileSize;
        }
        public void SetPhotoJPG(string photoJPG)
        {
            PhotoJPG = photoJPG;
        }
        public void SetGenre(int genre)
        {
            if (Enum.IsDefined(typeof(Genre), genre))
            {
                Genre = (Genre)genre;
            }
            else
            {
                Genre = Genre.Other;
            }
        }
        public string GetSongTitle()
        {
            return SongTitle;
        }
        public string GetArtist()
        {
            return Artist;
        }
        public string GetReleaseDate()
        {
            return SongReleaseDate;
        }
        public double GetPlaybackTime()
        {
            return PlaybackTime;
        }
        public decimal GetDownloadCost()
        {
            return DownloadCost;
        }
        public double GetFileSize()
        {
            return FileSize;
        }
        public string GetPhotoJPG()
        {
            return PhotoJPG;
        }
        public Genre GetGenre()
        {
            return Genre;
        }

        //constructors
        public MP3()
        {
            SongTitle = "Hotline Bling";
            Artist = "Drake";
            SongReleaseDate = "12/09/2016";
            PlaybackTime = 3.10;
            DownloadCost = 2.33m;
            FileSize = 1.9;
            PhotoJPG = "HotlineBling.JPG";
            Genre = Genre.Other;
        }

        public MP3(string songTitle, string artist, string songReleaseDate, double playbackTime, decimal downloadCost, double fileSize, string photoJPG, Genre genre)
        {
            SongTitle = songTitle;
            Artist = artist;
            SongReleaseDate = songReleaseDate;
            PlaybackTime = playbackTime;
            DownloadCost = downloadCost;
            FileSize = fileSize;
            PhotoJPG = photoJPG;
            Genre = genre;
        }

        public MP3(MP3 mp3)
        {
            SongTitle = mp3.SongTitle;
            Artist = mp3.Artist;
            SongReleaseDate = mp3.SongReleaseDate;
            PlaybackTime = mp3.PlaybackTime;
            DownloadCost = mp3.DownloadCost;
            FileSize = mp3.FileSize;
            PhotoJPG= mp3.PhotoJPG;
            Genre = mp3.Genre;
        }

        //methods

        public override string ToString()
        {
            return "MP3 Title:\t" + SongTitle.ToString() + "\n" + "Artist:\t" + Artist.ToString() + "\n" + "Release Date:\t" + SongReleaseDate.ToString() + "\t" + "Genre:\t" + Genre.ToString() + "\n" + "Download Cost:\t" + "$" + DownloadCost.ToString() + "\t" + "File Size:\t" + FileSize.ToString() + "MB" + "\n" + "Song Playtime:\t" + PlaybackTime.ToString() + "min" + "\t" + "Album Photo:\t" + PhotoJPG.ToString() + ".jpg"; ;
        }
    }
}
