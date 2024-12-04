namespace tp12;

public class Disque
{
    
}


// Classe Disque implémentant IRentable
public class irentDisque : IRentable
{
    public string Titre { get; set; }
    public string Artiste { get; set; }
    public double Duree { get; set; } // Durée en heures

    public irentDisque(string titre, string artiste, double duree)
    {
        Titre = titre;
        Artiste = artiste;
        Duree = duree;
    }

    public double CalculateRent()
    {
        // Par exemple, coût de location basé sur la durée
        return Duree * 2.0;
    }
}

// Classe Disque héritant de Publication
public class pubDisque : Publication
{
    public string Artiste { get; set; }
    public double Duree { get; set; } // Durée en heures

    public pubDisque(string titre, string artiste, double duree)
        : base(titre)
    {
        Artiste = artiste;
        Duree = duree;
    }

    public override void PublishDetails()
    {
        Console.WriteLine($"Disque : {Titre}, Artiste : {Artiste}, Durée : {Duree:F2} heures");
    }
}

public class absDisque : absArticle
{
    public string Artiste { get; set; }

    public absDisque(string titre, string artiste, double prix)
        : base(titre, prix)
    {
        Artiste = artiste;
    }

    public override void AfficherDetails()
    {
        Console.WriteLine($"Disque : {Titre}, Artiste : {Artiste}, Prix : {Prix:F2}€");
    }
}