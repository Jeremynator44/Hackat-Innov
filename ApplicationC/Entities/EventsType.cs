using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class EventsType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();
}
