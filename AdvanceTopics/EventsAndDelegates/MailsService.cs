using System;

public class MailService
{
    public void OnVideoEncode(object source, VideoEventArgs e)
    {
        Console.WriteLine("MailService: Sending an event" + e.Video.Title);
    }
}