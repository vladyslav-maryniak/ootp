namespace IteratorAndStateExample.Maryniak.Models;

public class IdleState : IState
{
    public void NextTrack(MusicPlayer context)
    {
        context.CurrentTrack = context.CurrentPlaylistIterator?.Next();

        if (context.CurrentTrack is null)
        {
            Console.WriteLine($"Starting the next track... The playlist is over :(");
            context.SetState(new IdleState());
        }
        else
        {
            Console.WriteLine($"Starting the {context.CurrentTrack?.Title ?? "Default Track"}");
            context.SetState(new PlayingState());
        }
    }

    public void Pause(MusicPlayer context)
    {
        Console.WriteLine($"There is nothing to pause in the Idle state.");
    }

    public void Play(MusicPlayer context)
    {
        context.CurrentTrack = context.CurrentPlaylistIterator?.Next();

        if (context.CurrentTrack is null)
        {
            Console.WriteLine($"Starting the track... The playlist is over :(");
            context.SetState(new IdleState());
        }
        else
        {
            Console.WriteLine($"Starting the track - {context.CurrentTrack?.Title ?? "Default Track"}");
            context.SetState(new PlayingState());
        }
    }
}
