using System;

public class MessageService
{
    public void OnVideoEncode(object source, VideoEventArgs e)
    {
        Console.WriteLine("MessageService: Sending a text");
    }
}