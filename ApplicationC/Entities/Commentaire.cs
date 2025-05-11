using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Commentaire
{
    public ulong Id { get; set; }

    public string Contenucommentaires { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int Hackathon { get; set; }

    public int? Equipe { get; set; }
}
