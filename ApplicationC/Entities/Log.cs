using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Log
{
    public ulong Id { get; set; }

    public int UserId { get; set; }

    public string IpAddress { get; set; } = null!;

    public string UserAgent { get; set; } = null!;

    public long EventType { get; set; }

    public string Details { get; set; } = null!;

    public bool Results { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual EventsType EventTypeNavigation { get; set; } = null!;

    public virtual Equipe User { get; set; } = null!;
}
