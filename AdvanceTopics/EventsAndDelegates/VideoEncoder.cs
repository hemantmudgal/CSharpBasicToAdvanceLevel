using System;

public class VideoEventArgs : EventArgs
{
    public Video Video { get; set; }
}

public class VideoEncoder
{
    //define delegate first.
    public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);

    //define an event.
    public event VideoEncoderEventHandler VideoEncoded;
    public void Enocde(Video video)
    {
        Console.WrieLine("Video Encoded");
        Thread.Sleep(3000);
        OnVideoEncoded(video);
    }

    //Raise an event.
    protected virtual void OnVideoEncoded(Video video)
    {
        if (VideoEncoded != null)
            VideoEncoded(this, new VideoEventArgs() {Video = video;});
    }
}