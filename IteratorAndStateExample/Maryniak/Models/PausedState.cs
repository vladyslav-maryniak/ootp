namespace IteratorAndStateExample.Maryniak.Models;

public class PausedState : IState
{
    public void Play(MusicPlayer context)
    {
        Console.WriteLine($"Resuming the {context.CurrentTrack?.Title ?? "Default Track"}.");
        context.SetState(new PlayingState());
    }

    public void Pause(MusicPlayer context)
    {
        Console.WriteLine($"The {context.CurrentTrack?.Title ?? "Default Track"} is already paused.");
    }

    public void NextTrack(MusicPlayer context)
    {
        context.CurrentTrack = context.CurrentPlaylistIterator?.Next();

        if (context.CurrentTrack is null)
        {
            Console.WriteLine($"Skipping to the next track... The playlist is over :(");
            context.SetState(new IdleState());
        }
        else
        {
            Console.WriteLine($"Skipping to the next track {context.CurrentTrack?.Title ?? "Default Track"}");
            context.SetState(new PlayingState());
        }
    }
}
