using System;

namespace Chocolate
{
    class ChocolateBar
    {

        public ChocolateBar(string Name, double WeightInG = 0, bool Melted = false, int Calories = 0)
        {
            this.Name = Name;
            this.WeightInG = WeightInG;
            this.Melted = Melted;
            this.Calories = Calories;
        }

        /// <summary>
        /// Number of calories per chocolate bar
        /// </summary>
        public int Calories;

        /// <summary>
        /// Weight in grams per chocolate bar
        /// </summary>
        public double WeightInG;

        /// <summary>
        /// Name of chocolate bar
        /// </summary>
        public string Name;

        /// <summary>
        /// Whether it's melted or not
        /// </summary>
        public bool Melted;

        /// <summary>
        /// Enjoy the chocolate bar goodness
        /// </summary>
        public void Eat()
        {
            Console.WriteLine($"Yum! You just ate a {Name} which was {Calories} calories and weighed {WeightInG}g");
            WeightInG = 0;
        }

        /// <summary>
        /// Throw the chocolate bar
        /// </summary>
        public void Throw()
        {
            Console.WriteLine("Ow!");
        }
    }
}