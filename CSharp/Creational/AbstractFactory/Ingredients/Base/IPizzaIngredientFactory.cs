namespace AbstractFactory.Ingredients.Base;
internal interface IPizzaIngredientFactory
{
    Dough CreateDough();
    Sauce CreateSauce();
    Cheese CreateCheese();
    List<Veggie> CreateVeggies();
    Pepperoni CreatePepperoni();
    Clam CreateClam();
}
