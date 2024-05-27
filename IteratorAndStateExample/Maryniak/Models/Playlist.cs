namespace IteratorAndStateExample.Maryniak.Models;

public class Playlist(string title) : IAggregate<Track>
{
    public string Title { get; set; } = title;

    private readonly List<Track> tracks = [];

    public void AddTrack(Track track) => tracks.Add(track);

    public IIterator<Track> GetIterator() => new PlaylistIterator(tracks);
}
