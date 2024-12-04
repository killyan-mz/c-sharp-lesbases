namespace tp12;

public class extention
{
    public static void afficherfilterarttype(List<ArticleTypé> A)
    {
        var persons = from p in A
            where p.Type == TypeArticle.Alimentaire
            select p.Nom;
        foreach (var person in persons)
        {
            Console.WriteLine(person);
        }
    }

    public static void afficherorderby(List<ArticleTypé> A)
    {
        var orderprix = A.OrderBy(f => f.Prix);
        foreach (var article in orderprix) { Console.WriteLine(article.Nom); }
    }

    public static void affichersommetotal1(List<ArticleTypé> A)
    {
        foreach (var article in A) {
            Console.WriteLine("- il y a "+article.Quantite+" "+article.Nom+(article.Quantite>1?"s":""));
        }
    }
    
    public static void affichersommetotal2(List<ArticleTypé> A)
    {
        int quantite = A.Sum(f => f.Quantite);
        Console.WriteLine($"le nombre total d'article est de {quantite}");
    }
}