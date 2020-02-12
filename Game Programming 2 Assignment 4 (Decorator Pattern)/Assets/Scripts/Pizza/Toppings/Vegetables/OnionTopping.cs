/*
*(Christopher Green)
*(OnionTopping.cs)
* (Assignment 4)
* (This script implements the Decorator in order to implement the functions of the abstract pizza class. )
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnionTopping : PizzaDecorator
{
    Pizza pizzaTopping;

    public OnionTopping(Pizza pizza)
    {
        this.pizzaTopping = pizza;
    }

    public override string GetDescription()
    {
        return pizzaTopping.GetDescription() + ", with onions";
    }

    public override float GetTotalCost()
    {
        return pizzaTopping.GetTotalCost() + 0.15f;
    }

    public override int GetTotalPizzaToppings()
    {
        return pizzaTopping.GetTotalPizzaToppings() + 1;
    }
}
