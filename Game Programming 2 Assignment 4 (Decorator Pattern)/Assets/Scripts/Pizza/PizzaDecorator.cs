/*
*(Christopher Green)
*(PizzaDecorator.cs)
* (Assignment 4)
* (This script is the decorator and it contains the basic information and "implementation" of the pizza class that it needs. )
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PizzaDecorator : Pizza
{
    public abstract override string GetDescription();
}
