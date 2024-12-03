namespace tp12;

public abstract class absArticle
{
    public string Titre { get; set; }
    public double Prix { get; set; }
    protected absArticle(string titre, double prix)
    {
        Titre = titre;
        Prix = prix;
    }
    public abstract void AfficherDetails();
}
public delegate double DiscountStrategy(absArticle article);


public enum TypeArticle
{
    Alimentaire,
    Droguerie,
    Habillement,
    Loisir
}


public struct Article {
    public string Nom { get; set; }
    public double Prix { get; set; }
    public int Quantite { get; set; }
    public Article(string nom, double prix, int quantite)
    {
        Nom = nom;
        Prix = prix;
        Quantite = quantite;
    }
    public void Afficher()
    {
        Console.WriteLine($"Article : {Nom}, Prix : {Prix:F2}€, Quantité : {Quantite}");
    }
    public void Ajouter(int quantite)
    {
        if (quantite > 0)
        {
            Quantite += quantite;
            Console.WriteLine($"Ajout de {quantite} à l'article {Nom}. Nouvelle quantité : {Quantite}");
        }
        else
        {
            Console.WriteLine("Quantité invalide pour l'ajout.");
        }
    }
    public void Retirer(int quantite)
    {
        if (quantite > 0 && Quantite >= quantite)
        {
            Quantite -= quantite;
            Console.WriteLine($"Retrait de {quantite} de l'article {Nom}. Nouvelle quantité : {Quantite}");
        }
        else
        {
            Console.WriteLine("Quantité invalide ou insuffisante pour le retrait.");
        }
    }
}

public struct ArticleTypé
{
    public string Nom { get; set; }
    public double Prix { get; set; }
    public int Quantite { get; set; }
    public TypeArticle Type { get; set; }

    // Constructeur pour initialiser un article
    public ArticleTypé(string nom, double prix, int quantite, TypeArticle type)
    {
        Nom = nom;
        Prix = prix;
        Quantite = quantite;
        Type = type;
    }

    // Méthode pour afficher les informations de l'article
    public void Afficher()
    {
        Console.WriteLine($"Article : {Nom}, Type : {Type}, Prix : {Prix:F2}€, Quantité : {Quantite}");
    }

    // Méthodes pour ajouter et retirer des quantités
    public void Ajouter(int quantite)
    {
        if (quantite > 0)
        {
            Quantite += quantite;
            Console.WriteLine($"Ajout de {quantite} à l'article {Nom}. Nouvelle quantité : {Quantite}");
        }
        else
        {
            Console.WriteLine("Quantité invalide pour l'ajout.");
        }
    }

    public void Retirer(int quantite)
    {
        if (quantite > 0 && Quantite >= quantite)
        {
            Quantite -= quantite;
            Console.WriteLine($"Retrait de {quantite} de l'article {Nom}. Nouvelle quantité : {Quantite}");
        }
        else
        {
            Console.WriteLine("Quantité invalide ou insuffisante pour le retrait.");
        }
    }
}

public struct tabart
{
    public string Nom { get; set; }
    public double Prix { get; set; }
    public int Quantite { get; set; }
    public TypeArticle Type { get; set; }
    
    public tabart(string nom, double prix, int quantite, TypeArticle type)
    {
        Nom = nom;
        Prix = prix;
        Quantite = quantite;
        Type = type;
    }

    // Méthode pour afficher les informations de l'article
    public void Afficher()
    {
        Console.WriteLine($"Article : {Nom}, Type : {Type}, Prix : {Prix:F2}€, Quantité : {Quantite}");
    }

    // Méthodes pour ajouter et retirer des quantités
    public void Ajouter(int quantite)
    {
        if (quantite > 0)
        {
            Quantite += quantite;
            Console.WriteLine($"Ajout de {quantite} à l'article {Nom}. Nouvelle quantité : {Quantite}");
        }
        else
        {
            Console.WriteLine("Quantité invalide pour l'ajout.");
        }
    }

    public void Retirer(int quantite)
    {
        if (quantite > 0 && Quantite >= quantite)
        {
            Quantite -= quantite;
            Console.WriteLine($"Retrait de {quantite} de l'article {Nom}. Nouvelle quantité : {Quantite}");
        }
        else
        {
            Console.WriteLine("Quantité invalide ou insuffisante pour le retrait.");
        }
    }
}