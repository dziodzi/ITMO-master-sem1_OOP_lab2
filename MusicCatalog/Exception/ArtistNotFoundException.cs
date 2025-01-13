namespace MusicCatalog.Exception;

public class ArtistNotFoundException(string artistName) : System.Exception($"Artist '{artistName}' not found.");