using System;

public class MailService
{
    public void OnVideoEncode(object source, EventArgs e)
    {
        Console.WriteLine("MailService: Sending an event");
    }
}