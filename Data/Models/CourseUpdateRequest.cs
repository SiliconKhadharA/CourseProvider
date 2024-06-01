

namespace Data.Models;

public class CourseUpdateRequest
{
    public string Id { get; set; } = null!;
    public string? Title { get; set; }
    public string? ImageUri { get; set; }
    public string? Likes { get; set; }
    public int Hours { get; set; }
    public List<AoutherUpdateRequest>? Authors { get; set; }
}

public class AoutherUpdateRequest
{
    public string? Name { get; set; }
}