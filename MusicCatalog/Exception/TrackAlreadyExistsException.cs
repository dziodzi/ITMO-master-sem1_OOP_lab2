namespace MusicCatalog.Exception;

public class TrackAlreadyExistsException(string trackName, string albumTitle)
    : System.Exception($"Track '{trackName}' already exists in album '{albumTitle}'.");