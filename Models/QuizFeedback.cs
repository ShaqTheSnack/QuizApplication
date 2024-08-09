using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplikation.Models
{
    public class QuizFeedback
    {
        //Dette er kommentar til hvad du for afvide baseret på antal point du har rigtige
        public string Point0 { get; set; } = "Åh nej, det var virkelig dårligt. Virklig!";
        public string Point1 { get; set; } = "Det var næsten imponerende, hvor dårligt det gik. Måske overvej at prøve igen... måske.";
        public string Point2 { get; set; } = "Du har formået at skuffe både dig selv og dine forældre. Hårdt arbejde.";
        public string Point3 { get; set; } = "Det er virkelig imponerende, hvor lidt du ved. Det er næsten imponerende... på den forkerte måde.";
        public string Point4 { get; set; } = "Bare lige over den absolutte bund. Du kunne muligvis have gjort det bedre ved at gætte.";
        public string Point5 { get; set; } = "Nå, du fik 5 point. Det er bedre end ingenting, men ikke meget bedre.";
        public string Point6 { get; set; } = "Hm, du klarede dig faktisk okay. Men det er stadig ikke noget at prale af.";
        public string Point7 { get; set; } = "Godt gået! Du er virkelig begyndt at få styr på det her.";
        public string Point8 { get; set; } = "Imponerende! Du har virkelig vist, at du kender dine ting.";
        public string Point9 { get; set; } = "Fantastisk arbejde! Du er meget tæt på perfektion.";
        public string Point10 { get; set; } = "Perfekt! Du er en sand ekspert. Flot klaret!";
        public string GetQuotes { get; set; }
    }
}
