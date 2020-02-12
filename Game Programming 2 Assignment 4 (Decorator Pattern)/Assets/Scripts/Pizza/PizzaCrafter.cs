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

    public int totalToppingsNum;
    public int totalPizzasNum;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        totalToppingsText.text = "Toppings: " + totalToppingsNum;
        totalPizzasText.text = "Pizzas: " + totalPizzasNum;
    }

    public void PickPizza(string pizzaName)
    {
        switch (pizzaName)
        {
            case "Cheese":
                this.pizza = new CheesePizza();
                break;
            case "Sausage":
                this.pizza = new SausagePizza();
                break;
            case "Pepperoni":
                this.pizza = new PepperoniPizza();
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
                totalToppingsNum++;
                break;

            case "Ham Topping":
                this.pizza = new HamTopping(pizza);
                totalToppingsNum++;
                break;

            case "Pepperoni Topping":
                this.pizza = new PepperoniTopping(pizza);
                totalToppingsNum++;
                break;

            case "Sausage Topping":
                this.pizza = new SausageTopping(pizza);
                totalToppingsNum++;
                break;

            case "Onion Topping":
                this.pizza = new OnionTopping(pizza);
                totalToppingsNum++;
                break;

            case "Bell Pepper Topping":
                this.pizza = new BellPepperTopping(pizza);
                totalToppingsNum++;
                break;

            case "Mushroom Topping":
                this.pizza = new MushroomTopping(pizza);
                totalToppingsNum++;
                break;

            case "Garlic Topping":
                this.pizza = new GarlicTopping(pizza);
                totalToppingsNum++;
                break;
        }
        DisplayPizza();
    }

    public void DisplayPizza()
    {
        pizzaStats.text = pizza.GetDescription() + " Total cost: " + pizza.GetTotalCost() + " with " + pizza.GetTotalPizzaToppings() + " total toppings.";
    }

}
