/*
*(Christopher Green)
*(BaconTopping.cs)
* (Assignment 4)
* (This script implements the Decorator in order to implement the functions of the abstract pizza class. )
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaconTopping : PizzaDecorator
{
    Pizza pizzaTopping;

    public BaconTopping(Pizza pizza)
    {
        this.pizzaTopping = pizza;
    }

    public override string GetDescription()
    {
        return pizzaTopping.GetDescription() + ", with bacon";
    }

    public override float GetTotalCost()
    {
        return pizzaTopping.GetTotalCost() + 1.50f;
    }

    public override int GetTotalPizzaToppings()
    {
        return pizzaTopping.GetTotalPizzaToppings() + 1;
    }
}
