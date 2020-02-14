/*
*(Christopher Green)
*(SausagePizza.cs)
* (Assignment 4)
* (This scripts contains the basic information about the sausage type of pizza.)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SausagePizza : Pizza
{
    public SausagePizza()
    {
        this.pizzaDescription = "Sausage Pizza";
    }

    public override float GetTotalCost()
    {
        return 7.00f;
    }

    public override int GetTotalPizzaToppings()
    {
        return 1;
    }
}
