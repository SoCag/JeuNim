using System;
using System.Collections.Generic;

namespace JeuNim.Models;

public partial class Participant
{
    public int IdParticipant { get; set; }

    public bool AGagne { get; set; }

    public bool ACommence { get; set; }

    public int IdPartie { get; set; }

    public int IdJoueur { get; set; }

    public virtual ICollection<Coup> Coups { get; set; } = new List<Coup>();

    public virtual Joueur IdJoueurNavigation { get; set; } = null!;

    public virtual Partie IdPartieNavigation { get; set; } = null!;
}
