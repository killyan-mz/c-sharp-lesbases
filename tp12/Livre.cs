namespace tp12;

public class Livre
{
    
}

// Classe Livre implémentant IRentable
public class irentLivre : IRentable
{
    public string Titre { get; set; }
    public string Auteur { get; set; }
    public int NombrePages { get; set; }

    public irentLivre(string titre, string auteur, int nombrePages)
    {
        Titre = titre;
        Auteur = auteur;
        NombrePages = nombrePages;
    }

    public double CalculateRent()
    {
        // Par exemple, coût de location basé sur le nombre de pages
        return NombrePages * 0.05;
    }
}

// Classe Livre héritant de Publication
public class pubLivre : Publication
{
    public string Auteur { get; set; }
    public int NombrePages { get; set; }

    public pubLivre(string titre, string auteur, int nombrePages)
        : base(titre)
    {
        Auteur = auteur;
        NombrePages = nombrePages;
    }

    public override void PublishDetails()
    {
        Console.WriteLine($"Livre : {Titre}, Auteur : {Auteur}, Nombre de pages : {NombrePages}");
    }
}

public class absLivre : absArticle
{
    public string Auteur { get; set; }

    public absLivre(string titre, string auteur, double prix)
        : base(titre, prix)
    {
        Auteur = auteur;
    }

    public override void AfficherDetails()
    {
        Console.WriteLine($"Livre : {Titre}, Auteur : {Auteur}, Prix : {Prix:F2}€");
    }
}