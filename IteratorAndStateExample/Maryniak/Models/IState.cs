namespace IteratorAndStateExample.Maryniak.Models;

public interface IState
{
    void Play(MusicPlayer context);
    void Pause(MusicPlayer context);
    void NextTrack(MusicPlayer context);
}
