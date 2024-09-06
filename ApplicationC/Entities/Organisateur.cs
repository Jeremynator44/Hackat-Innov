using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Organisateur
{
    public int Idorganisateur { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Hackathon> Hackathons { get; set; } = new List<Hackathon>();
}
