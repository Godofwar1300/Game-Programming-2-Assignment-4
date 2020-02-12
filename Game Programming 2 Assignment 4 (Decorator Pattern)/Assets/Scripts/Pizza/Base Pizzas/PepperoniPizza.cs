/*
*(Christopher Green)
*(PepperoniPizza.cs)
* (Assignment 4)
* (This scripts contains the basic information about the pepperoni type of pizza.)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepperoniPizza : Pizza
{
    public PepperoniPizza()
    {
        this.pizzaDescription = "Pepperoni Pizza";
    }

    public override float GetTotalCost()
    {
        return 7.75f;
    }

    public override int GetTotalPizzaToppings()
    {
        return 1;
    }
}
