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
    public delegate void PhotoEventHandler(Photo photo);
    public void Process(string path, PhotoEventHandler filterHandler)
    {
        Photo photo = new Load(path);
        filterHandler(photo);
        photo.Save();
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var photoProcessor = new PhotoProcessor();
        var photoFilters = new PhotoFilters();
        //Delegate is a pointer to a mehtod with the signature.
        PhotoProcessor.PhotoEventHandler filterHandler = photoFilters.ApplyBrightness();
        filterHandler += photoFilters.ApplyContrast();
        filterHandler += photoFilters.ResizeImage();
        filterHandler += RedEyesRemoved();

        photoProcessor.Process("photo.jpg",filterHandler)
    }

    static void RedEyesRemoved(Photo photo)
    {
        Console.WriteLine("Removed Red Eyes");
    }
}