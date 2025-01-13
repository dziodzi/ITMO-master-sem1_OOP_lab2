namespace MusicCatalog.Exception;

public class AlbumAlreadyExistsException(string albumTitle, string artistName)
    : System.Exception($"Album '{albumTitle}' already exists for artist '{artistName}'.");