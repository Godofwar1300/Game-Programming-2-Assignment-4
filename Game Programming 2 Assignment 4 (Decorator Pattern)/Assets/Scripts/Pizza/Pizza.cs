/*
*(Christopher Green)
*(Pizza.cs)
* (Assignment 4)
* (This script is the base abstract class of pizza.)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pizza
{

    public string pizzaDescription = "Default Pizza";

    
    public virtual string GetDescription()
    {
        return pizzaDescription;
    }

    public abstract float GetTotalCost();

    public abstract int GetTotalPizzaToppings();

}
