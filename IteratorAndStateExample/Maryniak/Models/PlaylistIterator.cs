namespace IteratorAndStateExample.Maryniak.Models;

public class PlaylistIterator(List<Track> tracks) : IIterator<Track>
{
    private int position = 0;

    public Track? Current => tracks.ElementAtOrDefault(position);

    public bool HasNext => position < tracks.Count;

    public Track? Next()
        => HasNext ? tracks[position++] : null;

    public void Restart() => position = 0;
}
