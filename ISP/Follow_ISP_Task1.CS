public interface IPlayAudio
{
    void PlayAudio();
}

public interface IPlayVideo
{
    void PlayVideo();
}

public interface IDisplaySubtitles
{
    void PlaySubtitles();
}

public interface ILoadMedia
{
    void LoadMedia();
}

public class AudioPlayer : IPlayAudio, ILoadMedia
{
    public void PlayAudio()
    {
        // Code to play audio
    }

    public void LoadMedia(string filePath)
    {
        // Code to load audio file
    }
}
public class VideoPlayer : IPlayVideo, IDisplaySubtitles, ILoadMedia
{
    public void PlayVideo()
    {
        // Code to play video
    }
    public void DisplaySubtitles()
    {
        // Code to display subtitles
    }
    public void LoadMedia(string filePath)
    {
        // Code to load video file
    }
}