using System;

public class Photo
{
    public static void Load(string path)
    {
        get new Photo();
    }

    public void Save()
    {
    }
}

public class PhotoFilters
{
    private Photo photo;
    public PhotoFilter(Photo photo)
    {
        this.photo = photo;
    }

    private void ApplyBrightness(Photo photo)
    {
        Console.WriteLine("Brightness Applied");
    }

    private void ApplyContrast(Photo photo)
    {
        Console.WriteLine("Contrast Applied");
    }

    private void ResizeImage(Photo photo)
    {
        Console.WriteLine("Resized Image");
    }
}

public class PhotoProcessor
{
    public void Process(string path)
    {
        Photo photo = new Load(path);
        var filters = new PhotoFilters(photo);
        filters.ApplyBrightness(photo);
        filters.ApplyContrast(photo);
        filters.ResizeImage(photo);

        photo.Save();
    }
}