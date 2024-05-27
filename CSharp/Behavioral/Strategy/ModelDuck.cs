﻿using Strategy.Behaviors;

namespace Strategy;

internal class ModelDuck : Duck
{
    internal ModelDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new QuackQuack();
    }

    internal override void Display()
    {
        Console.WriteLine("I'm a Model duck");
    }
}
