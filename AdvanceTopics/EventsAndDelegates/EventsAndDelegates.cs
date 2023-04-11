using System;

public class EventAndDelegate
{
    static void Main(string[] args)
    {
        var video = new Video() { Title = "Title1" };
        var videoEncoder = new VideoEncoder();
        var mailSerive = new MailsService();
        var messageService = new MessageService();
        videoEncoder.VideoEncoded += mailSerive.OnVideoEncode;
        videoEncoder.VideoEncoded += messageService.OnVideoEncode;
        videoEncoder.Encode(video);
    }

}
