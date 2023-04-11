using System;

public class EventAndDelegate
{
    static void Main(string[] args)
    {
        var video = new Video() { Title = "Title1" };
        var videoEncoder = new VideoEncoder();

        videoEncoder.Encode(video);
    }

}
