namespace tp12;

public class Program
{
    
    public static double RemiseFixe(absArticle article)
    {
        return article.Prix * 0.10;
    }

    public static double RemiseParType(absArticle article)
    {
        if (article is absLivre)return article.Prix * 0.15; // 15% pour les livres
        if (article is absDisque)return article.Prix * 0.20; // 20% pour les disques
        if (article is absVideo)return article.Prix * 0.05; // 5% pour les vidéos
        return 0;
    }
    
    public static void Main()
    {
        bool[] visible = {true,true,true,true,true,true};
        Console.WriteLine("---------------------------------exercice article---------------------------------------");
        if (visible[0]){
            Article[] articles =
            {
                new Article("Stylo", 1.5, 10),
                new Article("Cahier", 3.2, 5)
            };
            Console.WriteLine("Articles initiaux :");
            foreach (Article article in articles){article.Afficher();}
            Console.WriteLine("\nModification des quantités :");
            articles[0].Ajouter(5);articles[1].Retirer(2);
            Console.WriteLine("\nArticles après modification :");
            foreach (Article article in articles){article.Afficher();}
            if (false)
            {
                            Console.WriteLine("\nCréation d'un nouvel article :");
                            Console.Write("Nom de l'article : ");string nom = Console.ReadLine();
                            Console.Write("Prix de l'article : ");double prix = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Quantité de l'article : ");int quantite = Convert.ToInt32(Console.ReadLine());
                            Article nouvelArticle = new Article(nom, prix, quantite);
                            Console.WriteLine("\nArticle créé :");
                            nouvelArticle.Afficher();
            }
        }
        Console.WriteLine("------------------------------exercice article type-------------------------------------");
        if (visible[1]){
            ArticleTypé[] articles =
            {
                new ArticleTypé("Pomme", 2.5, 20, TypeArticle.Alimentaire),
                new ArticleTypé("Savon", 1.2, 15, TypeArticle.Droguerie)
            };
            Console.WriteLine("Articles initiaux :");
            foreach (ArticleTypé article in articles){article.Afficher();}
            Console.WriteLine("\nModification des quantités :");
            articles[0].Ajouter(10);articles[1].Retirer(5);
            Console.WriteLine("\nArticles après modification :");
            foreach (ArticleTypé article in articles){article.Afficher();}
            if (false)
            {
                Console.WriteLine("\nCréation d'un nouvel article :");
                Console.Write("Nom de l'article : ");
                string nom = Console.ReadLine();

                Console.Write("Prix de l'article : ");
                double prix = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantité de l'article : ");
                int quantite = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type de l'article (Alimentaire, Droguerie, Habillement, Loisir) : ");
                string typeString = Console.ReadLine();
                TypeArticle type;

                // Validation du type entré par l'utilisateur
                if (Enum.TryParse(typeString, true, out type))
                {
                    ArticleTypé nouvelArticle = new ArticleTypé(nom, prix, quantite, type);
                    Console.WriteLine("\nArticle créé :");
                    nouvelArticle.Afficher();
                }
                else
                {
                    Console.WriteLine("Type d'article invalide. Article non créé.");
                }
            }
        }
        Console.WriteLine("------------------------------exercice tableau article----------------------------------");
        if (visible[2])
        {
            tabart[] articles = new tabart[3];
            articles[0] = new tabart("Pomme", 2.5, 20, TypeArticle.Alimentaire);
            articles[1] = new tabart("Savon", 1.2, 15, TypeArticle.Droguerie);
            articles[2] = new tabart("T-shirt", 12.99, 5, TypeArticle.Habillement);
            Console.WriteLine("Articles initiaux :");
            foreach (var article in articles){article.Afficher();}
            Console.WriteLine("\nModification des quantités :");
            articles[0].Ajouter(10);articles[1].Retirer(5);
            Console.WriteLine("\nArticles après modification :");
            foreach (var article in articles){article.Afficher();}
            if (false)
            {
                // Création d'un nouvel article par saisie utilisateur et ajout au tableau
                Console.WriteLine("\nAjout d'un nouvel article au tableau :");
                Console.Write("Nom de l'article : ");
                string nom = Console.ReadLine();

                Console.Write("Prix de l'article : ");
                double prix = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantité de l'article : ");
                int quantite = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type de l'article (Alimentaire, Droguerie, Habillement, Loisir) : ");
                string typeString = Console.ReadLine();
                if (Enum.TryParse(typeString, true, out TypeArticle type))
                {
                    Array.Resize(ref articles, articles.Length + 1); // Agrandir le tableau
                    articles[^1] = new tabart(nom, prix, quantite, type); // Ajouter l'article

                    Console.WriteLine("\nNouvel article ajouté au tableau :");
                    articles[^1].Afficher();
                }
                else
                {
                    Console.WriteLine("Type d'article invalide. Article non ajouté.");
                }

                // Afficher tous les articles après ajout
                Console.WriteLine("\nListe finale des articles :");
                foreach (var article in articles)
                {
                    article.Afficher();
                }
            }
        }
        Console.WriteLine("-----------------------------------exercice 1-------------------------------------------");
        if (visible[3])
        {
            List<IRentable> articles = new List<IRentable>
            {
                new irentLivre("Le Petit Prince", "Antoine de Saint-Exupéry", 96),
                new irentDisque("Abbey Road", "The Beatles", 0.75),
                new irentVideo("Inception", "Christopher Nolan", 2.5)
            };
            Console.WriteLine("Coûts de location des articles :");
            foreach (var article in articles)
            {
                double rentCost = article.CalculateRent();
                Console.WriteLine($"Article : {article.GetType().Name}, Coût de location : {rentCost:F2}€");
            }
        }
        Console.WriteLine("-----------------------------------exercice 2-------------------------------------------");
        if (visible[4])
        {
            List<Publication> publications = new List<Publication>
            {
                new pubLivre("Le Petit Prince", "Antoine de Saint-Exupéry", 96),
                new pubDisque("Abbey Road", "The Beatles", 0.75),
                new pubVideo("Inception", "Christopher Nolan", 2.5)
            };
            Console.WriteLine("Détails des publications :");
            foreach (var publication in publications){publication.PublishDetails();}
        }
        Console.WriteLine("-----------------------------------exercice 3-------------------------------------------");
        if (visible[5])
        {
            List<absArticle> articles = new List<absArticle>
            {
                new absLivre("Le Petit Prince", "Antoine de Saint-Exupéry", 15.0),
                new absDisque("Abbey Road", "The Beatles", 25.0),
                new absVideo("Inception", "Christopher Nolan", 30.0)
            };
            DiscountStrategy remiseFixe=RemiseFixe,remiseParType=RemiseParType;
            Console.WriteLine("Application des remises :");
            foreach (var article2 in articles)
            {
                article2.AfficherDetails();
                double montantRemiseFixe=remiseFixe(article2),montantRemiseType= remiseParType(article2);
                Console.WriteLine($"  - Remise fixe : {montantRemiseFixe:F2}€");
                Console.WriteLine($"  - Remise par type : {montantRemiseType:F2}€");
                Console.WriteLine($"  - Prix final avec remise par type : {(article2.Prix - montantRemiseType):F2}€");
                Console.WriteLine();
            }
        }
        Console.WriteLine("--------------------------------------fin-----------------------------------------------");
    }
}  