using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplikation.Models
{
    public class Category
    {
        // Definerer egenskaber til kategorier
        public string History { get; set; }
        public string Science { get; set; }
        public string Movies { get; set; }
        public string Geography { get; set; }
        public string Sports { get; set; }
        public string Programming { get; set; }
        public string Database { get; set; }
        public string ClientSide { get; set; }
        public string Network { get; set; }
        public string GUI { get; set; }

        // Standard konstruktør, som initialiserer egenskaberne
        public Category()
        {
            // Initialiserer hver kategori med det tilsvarende navn
            History = "History";
            Science = "Science";
            Movies = "Movies";
            Geography = "Geography";
            Sports = "Sports";
            Programming = "Programming";
            Database = "Database";
            ClientSide = "ClientSide";
            Network = "Network";
            GUI = "GUI";
        }
    }

}
