namespace MorePizza.Model
{
    public class PizzaModel
    {
        public int PizzaId { get; set; }
        public int SlicesOfPizza { get; set; }

        public PizzaModel(int pizzaId, int pizzaSlices)
        {
            PizzaId = pizzaId;
            SlicesOfPizza = pizzaSlices;
        }
    }
}