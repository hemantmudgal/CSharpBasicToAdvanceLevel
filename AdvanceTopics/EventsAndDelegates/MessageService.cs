using System;

public class MessageService
{
    public void OnVideoEncode(object source, EventArgs e)
    {
        Console.WriteLine("MessageService: Sending a text");
    }
}