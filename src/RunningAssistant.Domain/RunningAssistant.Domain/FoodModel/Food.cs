using RunningAssistant.Domain.Toolkit.Domain;

namespace RunningAssistant.Domain.FoodModel
{
    public class Food : Entity
    {
        public Food(
            string name
            , float colorie = 0
            , float proteins = 0
            , float fats = 0
            , float carbohydrates = 0)
        {
            Name = name;
            Calorie = colorie;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
        }

        public string Name { get; private set; }
        public float Calorie { get; private  set; }
        public float Proteins { get; private set; }
        public float Fats { get; private set; }
        public float Carbohydrates { get; private set; } 
    }
}
