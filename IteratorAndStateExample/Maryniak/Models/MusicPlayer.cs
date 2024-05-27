namespace IteratorAndStateExample.Maryniak.Models;

public class MusicPlayer
{
    private readonly Dictionary<string, Playlist> playlists = [];

    public IIterator<Track>? CurrentPlaylistIterator { get; private set; }
    public Track? CurrentTrack { get; set; }

    public void SetCurrentPlaylist(string name)
        => CurrentPlaylistIterator = playlists[name].GetIterator();

    private IState state = new IdleState();

    public void SetState(IState state) => this.state = state;

    public void Play() => state.Play(this);

    public void Pause() => state.Pause(this);

    public void NextTrack() => state.NextTrack(this);

    public void AddPlaylist(string name, Playlist playlist)
        => playlists.Add(name, playlist);
}
