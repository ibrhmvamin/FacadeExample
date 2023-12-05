namespace FacadeExample
{
    
    public class AudioPlayer
    {
        public void PlayAudio(string audioFile)
        {
            Console.WriteLine($"Playing audio: {audioFile}");
        }
    }

   public class VideoPlayer
    {
        public void PlayVideo(string videoFile)
        {
            Console.WriteLine($"Playing video: {videoFile}");
        }
    }

    public class Display
    {
        public void ShowOnScreen()
        {
            Console.WriteLine("Showing content on the screen");
        }
    }

   public class MultimediaFacade
    {
        private AudioPlayer audioPlayer;
        private VideoPlayer videoPlayer;
        private Display display;

        public MultimediaFacade()
        {
            audioPlayer = new AudioPlayer();
            videoPlayer = new VideoPlayer();
            display = new Display();
        }

        public void PlayMultimedia(string audioFile, string videoFile)
        {
            Console.WriteLine("Playing Multimedia:");
            audioPlayer.PlayAudio(audioFile);
            videoPlayer.PlayVideo(videoFile);
            display.ShowOnScreen();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MultimediaFacade multimediaFacade = new MultimediaFacade();
            multimediaFacade.PlayMultimedia("song.mp3", "movie.mp4");
        }
    }

}