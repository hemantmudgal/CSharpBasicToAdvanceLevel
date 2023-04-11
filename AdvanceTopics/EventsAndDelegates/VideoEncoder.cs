using System;

public class VideoEncoder
{
    //define delegate first.
    public delegate void VideoEncoderEventHandler(object source, EventArgs args);

    //define an event.
    public event VideoEncoderEventHandler VideoEncoded;
    public void Enocde(Video video)
    {
        Console.WrieLine("Video Encoded");
        Thread.Sleep(3000);
        OnVideoEncoded();
    }

    //Raise an event.
    protected virtual void OnVideoEncoded()
    {
        if (VideoEncoded != null)
            VideoEncoded(this, EventsArgs.Empty);
    }
}