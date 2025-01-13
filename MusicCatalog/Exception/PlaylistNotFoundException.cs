namespace MusicCatalog.Exception;

public abstract class PlaylistNotFoundException(string albumTitle)
    : System.Exception($"Playlist '{albumTitle}' not found.");