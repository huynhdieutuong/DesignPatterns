namespace AbstractFactory.Ingredients.Base;
internal class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThickCrushDough();
    }

    public Sauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public Cheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public List<Veggie> CreateVeggies()
    {
        return [new BlackOlives(), new Spinach(), new EggPlant()];
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Clam CreateClam()
    {
        return new FrozenClams();
    }
}
