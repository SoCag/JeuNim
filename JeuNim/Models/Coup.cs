using System;
using System.Collections.Generic;

namespace JeuNim.Models;

public partial class Coup
{
    public int IdCoup { get; set; }

    public int NbBaton { get; set; }

    public int Ordre { get; set; }

    public int IdParticipant { get; set; }

    public virtual Participant IdParticipantNavigation { get; set; } = null!;
}
