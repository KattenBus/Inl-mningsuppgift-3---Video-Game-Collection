using System;
using System.Security.Cryptography.X509Certificates;

public class VideoGame
{
    public string Title { get; set; }
    public string Plattform { get; set; }
    public string Genre { get; set; }
    public string ReleaseYear { get; set; }
    public string ImagePath { get; set; }
    public VideoGame(string title, string plattform, string genre, string releaseYear, string imagePath)
    {
        Title = title;
        Plattform = plattform;
        Genre = genre;
        ReleaseYear = releaseYear;
        ImagePath = imagePath;
    }
}
