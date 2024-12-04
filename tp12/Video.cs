namespace tp12;

public class Video
{
    
}

// Classe Vidéo implémentant IRentable
public class irentVideo : IRentable
{
    public string Titre { get; set; }
    public string Réalisateur { get; set; }
    public double Duree { get; set; } // Durée en heures

    public irentVideo(string titre, string réalisateur, double duree)
    {
        Titre = titre;
        Réalisateur = réalisateur;
        Duree = duree;
    }

    public double CalculateRent()
    {
        // Par exemple, coût de location avec un tarif fixe par heure
        return Duree * 3.0;
    }
}

// Classe Vidéo héritant de Publication
public class pubVideo : Publication
{
    public string Réalisateur { get; set; }
    public double Duree { get; set; } // Durée en heures

    public pubVideo(string titre, string réalisateur, double duree)
        : base(titre)
    {
        Réalisateur = réalisateur;
        Duree = duree;
    }

    public override void PublishDetails()
    {
        Console.WriteLine($"Vidéo : {Titre}, Réalisateur : {Réalisateur}, Durée : {Duree:F2} heures");
    }
}

public class absVideo : absArticle
{
    public string Réalisateur { get; set; }

    public absVideo(string titre, string réalisateur, double prix)
        : base(titre, prix)
    {
        Réalisateur = réalisateur;
    }

    public override void AfficherDetails()
    {
        Console.WriteLine($"Vidéo : {Titre}, Réalisateur : {Réalisateur}, Prix : {Prix:F2}€");
    }
}