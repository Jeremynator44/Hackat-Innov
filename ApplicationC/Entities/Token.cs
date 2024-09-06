using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Token
{
    public string Uuid { get; set; } = null!;

    public int Idequipe { get; set; }

    public virtual Equipe IdequipeNavigation { get; set; } = null!;
}
