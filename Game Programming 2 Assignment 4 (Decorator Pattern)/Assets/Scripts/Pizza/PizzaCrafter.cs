using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PizzaCrafter : MonoBehaviour
{

    Pizza pizza;

    public Text pizzaStats;
    public Text totalPizzasText;
    public Text totalToppingsText;
    public Text totalCostText;

    public int totalToppingsNum;
    public int totalPizzasNum;
    public float totalCostNum;

    // Start is called before the first frame update
    void Start()
    {
        pizzaStats.text = "Pick one type of pizza per order and add no more than 4 toppings.";
    }

    // Update is called once per frame
    void Update()
    {
        totalToppingsText.text = "Toppings: " + totalToppingsNum;
        totalPizzasText.text = "Pizzas: " + totalPizzasNum;
        totalCostText.text = "Cost: $" + totalCostNum;
    }

    public void PickPizza(string pizzaName)
    {
        switch (pizzaName)
        {
            case "Cheese":
                this.pizza = new CheesePizza();
                totalPizzasNum++;
                break;
            case "Sausage":
                this.pizza = new SausagePizza();
                totalPizzasNum++;
                break;
            case "Pepperoni":
                this.pizza = new PepperoniPizza();
                totalPizzasNum++;
                break;
        }
        DisplayPizza();
    }

    public void AddTopping(string toppingName)
    {
        switch (toppingName)
        {
            case "Bacon Topping":
                this.pizza = new BaconTopping(pizza);
                break;

            case "Ham Topping":
                this.pizza = new HamTopping(pizza);
                break;

            case "Pepperoni Topping":
                this.pizza = new PepperoniTopping(pizza);
                break;

            case "Sausage Topping":
                this.pizza = new SausageTopping(pizza);
                break;

            case "Onion Topping":
                this.pizza = new OnionTopping(pizza);
                break;

            case "Bell Pepper Topping":
                this.pizza = new BellPepperTopping(pizza);
                break;

            case "Mushroom Topping":
                this.pizza = new MushroomTopping(pizza);
                break;

            case "Garlic Topping":
                this.pizza = new GarlicTopping(pizza);
                break;
        }
        DisplayPizza();
    }

    public void DisplayPizza()
    {
        pizzaStats.text = pizza.GetDescription() + " Total cost: $" + pizza.GetTotalCost() + " with " + pizza.GetTotalPizzaToppings() + " total toppings.";

        totalCostNum = pizza.GetTotalCost();
        totalToppingsNum = pizza.GetTotalPizzaToppings();
    }

}
