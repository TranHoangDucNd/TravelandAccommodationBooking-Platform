﻿namespace TND.Domain.Models
{
    public record PaginatedList<TItem>(
        IEnumerable<TItem> Items,
        PaginationMetadata PaginationMetadata); 
}
