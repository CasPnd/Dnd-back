namespace Dnd.DAL.Models;

public class PageDto
{
    public string Name { get; set; }
    public string Type { get; set; }
    public byte Rare { get; set; }
    public string Source { get; set; }
    public string Text { get; set; }
    public byte[]? MainImage { get; set; }
    public byte[]? Images { get; set; }
    public List<string> Tags { get; set; }
}