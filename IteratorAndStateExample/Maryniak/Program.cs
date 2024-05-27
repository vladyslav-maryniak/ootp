using IteratorAndStateExample.Maryniak.Models;

namespace IteratorAndStateExample.Maryniak;

internal class Program
{
    static void Main()
    {
        var player = new MusicPlayer();
        
        var playlist = new Playlist(title: "Classic");
        playlist.AddTrack(new Track("Metallica - Nothing Else Matters"));
        playlist.AddTrack(new Track("Red Hot Chili Peppers - Californication"));
        playlist.AddTrack(new Track("Black Sabbath - Paranoid"));
        player.AddPlaylist(playlist.Title, playlist);

        player.SetCurrentPlaylist(playlist.Title);

        player.Play();
        player.NextTrack();
        player.Play();
        player.Pause();
        player.Play();
        player.NextTrack();
        player.Pause();
        player.NextTrack();
        player.Pause();
    }
}
