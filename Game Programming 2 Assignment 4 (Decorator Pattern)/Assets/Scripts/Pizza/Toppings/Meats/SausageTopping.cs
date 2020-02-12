/*
*(Christopher Green)
*(SausageTopping.cs)
* (Assignment 4)
* (This script implements the Decorator in order to implement the functions of the abstract pizza class. )
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SausageTopping : PizzaDecorator
{

    Pizza pizzaTopping;


    public SausageTopping(Pizza pizza)
    {
        this.pizzaTopping = pizza;
    }

    public override string GetDescription()
    {
        return pizzaTopping.GetDescription();//", with sausage";
    }

    public override float GetTotalCost()
    {
        return pizzaTopping.GetTotalCost() + 1.00f;
    }

    public override int GetTotalPizzaToppings()
    {
        return pizzaTopping.GetTotalPizzaToppings() + 1;
    }
}
