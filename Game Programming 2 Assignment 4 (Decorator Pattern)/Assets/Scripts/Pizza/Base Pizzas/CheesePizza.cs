/*
*(Christopher Green)
*(CheesePizza.cs)
* (Assignment 4)
* (This scripts contains the basic information about the cheese type of pizza.)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheesePizza : Pizza
{
    public CheesePizza()
    {
        this.pizzaDescription = "Cheese Pizza";
    }

    public override float GetTotalCost()
    {
        return 6.75f;
    }

    public override int GetTotalPizzaToppings()
    {
        return 1;
    }
}
