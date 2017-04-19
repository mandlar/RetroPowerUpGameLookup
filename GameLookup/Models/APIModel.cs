using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameLookup.Models
{
    public class ReleaseDate
    {
        public int category { get; set; }
        public int platform { get; set; }
        public object date { get; set; }
        public int region { get; set; }
        public string human { get; set; }
        public int y { get; set; }
        public int m { get; set; }
    }

    public class AlternativeName
    {
        public string name { get; set; }
        public string comment { get; set; }
    }

    public class Screenshot
    {
        public string url { get; set; }
        public string cloudinary_id { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Video
    {
        public string name { get; set; }
        public string video_id { get; set; }
    }

    public class Cover
    {
        public string url { get; set; }
        public string cloudinary_id { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Esrb
    {
        public string synopsis { get; set; }
        public int rating { get; set; }
    }

    public class Pegi
    {
        public int rating { get; set; }
    }

    public class Game
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public long created_at { get; set; }
        public long updated_at { get; set; }
        public string summary { get; set; }
        public string storyline { get; set; }
        public int collection { get; set; }
        public int hypes { get; set; }
        public double rating { get; set; }
        public double popularity { get; set; }
        public double aggregated_rating { get; set; }
        public int rating_count { get; set; }
        public List<int> developers { get; set; }
        public List<int> publishers { get; set; }
        public int category { get; set; }
        public List<int> player_perspectives { get; set; }
        public List<int> game_modes { get; set; }
        public List<int> keywords { get; set; }
        public List<int> themes { get; set; }
        public List<int> genres { get; set; }
        public long first_release_date { get; set; }
        public List<ReleaseDate> release_dates { get; set; }
        public List<AlternativeName> alternative_names { get; set; }
        public List<Screenshot> screenshots { get; set; }
        public List<Video> videos { get; set; }
        public Cover cover { get; set; }
        public Esrb esrb { get; set; }
        public Pegi pegi { get; set; }

        public string GetGameName()
        {
            return name.ToUpper();
        }

        public string GetGameInformation()
        {
            string information = "";

            if (developers != null)
            {
                foreach (int developer in developers)
                {
                    information += developer + "/";
                }
            }

            if (publishers != null)
            {
                foreach (int publisher in publishers)
                {
                    information += publisher + "/";
                }
            }

            information += " | ";

            if (release_dates != null)
            {
                foreach (ReleaseDate releaseDate in release_dates)
                {
                    information += releaseDate.human + " ";
                }
            }

            return information;
            //return "Developer/Publisher | NOV 11, 2001";
        }
    }

    public class GameSearch
    {
        public List<Game> games { get; set; } 
    }
}