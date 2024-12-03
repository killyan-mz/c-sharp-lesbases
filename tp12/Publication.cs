namespace tp12;
using System;
using System.Collections.Generic;

// Classe abstraite Publication
public abstract class Publication
{
    public string Titre { get; set; }

    protected Publication(string titre)
    {
        Titre = titre;
    }

    // Méthode abstraite à implémenter par les classes dérivées
    public abstract void PublishDetails();
}

