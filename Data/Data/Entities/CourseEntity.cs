﻿

using System.ComponentModel.DataAnnotations;

namespace Data.Data.Entities;

public class CourseEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string? ImageUri { get; set; }

    public string? ImageHeaderUri { get; set; }

    public bool IsBestseller { get; set; }

    public bool IsDigital { get; set; }

    public string[]? Categories { get; set; }

    public string? Title { get; set; }

    public string? Ingress { get; set; }

    public decimal StarRating { get; set; }

    public string? Reviews { get; set; }

    public string? LikesInProcent { get; set; }

    public string? Likes { get; set; }

    public int Hours { get; set; }

    public virtual List<AoutherEntity>? Authors { get; set; }

    public virtual PricesEntity? Prices { get; set; }

    public virtual ContentEntity? Content { get; set; }
}
