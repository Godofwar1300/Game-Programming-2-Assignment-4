/*
*(Christopher Green)
*(PizzaCrafter.cs)
* (Assignment 4)
* (This script implements and utilizes funtions from the decotrator and acts as the games game manager. )
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PizzaCrafter : MonoBehaviour
{

    public AudioManager audioMan;

    Pizza pizza;

    public GameObject gameScreen;
    public GameObject pizzaTypeButtons;
    public GameObject meatToppingButtons;
    public GameObject veggieToppingButtons;
    public GameObject bakeButton;

    public GameObject resultsScreen;
    public Text resultsText;
    public bool gameIsOver;


    public Text pizzaStats;
    public Text budgetText;


    public Text timerText;
    public float duration;

    public int currentToppingsNum;
    public int totalToppingsNum;

    public int currentPizzaNum;
    public int totalPizzasNum;

    public float totalCostNum;
    public int randomTotalCost;
    //public int finalizedTotalCost;

    public bool pickPizzaType;
    public bool pickPizzaToppings;
    public bool canPlay;

    public Button cheesePizzaButton;
    public Button sausagePizzaButton;
    public Button pepperoniPizzaButton;
    public Button startGameButton;



    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "Timer: 30" ;

        canPlay = false;
        gameIsOver = false;
        pickPizzaType = true;
        pickPizzaToppings = false;

        cheesePizzaButton.interactable = false;
        sausagePizzaButton.interactable = false;
        pepperoniPizzaButton.interactable = false;


        pizzaTypeButtons.SetActive(true);
        bakeButton.SetActive(false);
        meatToppingButtons.SetActive(false);
        veggieToppingButtons.SetActive(false);
        pizzaStats.text = "Pick one type of pizza per order and pay close attention to the total cost and don't go over your budget! Click on the pizza in the top right corner to start the game. ";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("The random total cost for this round is: " + randomTotalCost);

        budgetText.text = "Budget: $" + randomTotalCost;

        if(canPlay)
        {
            startGameButton.interactable = false;
        }

        if(!gameIsOver)
        {
            gameScreen.SetActive(true);
            resultsScreen.SetActive(false);
        }
        else
        {
            gameScreen.SetActive(false);
            resultsScreen.SetActive(true);
        }

    }

    public void PickPizza(string pizzaName)
    {
        if (pickPizzaType)
        {
            switch (pizzaName)
            {
                case "Cheese":
                    this.pizza = new CheesePizza();
                    //totalPizzasNum++;
                    pickPizzaType = false;
                    pickPizzaToppings = true;

                    pizzaTypeButtons.SetActive(false);
                    bakeButton.SetActive(true);
                    meatToppingButtons.SetActive(true);
                    veggieToppingButtons.SetActive(true);
                    break;
                case "Sausage":
                    this.pizza = new SausagePizza();
                    //totalPizzasNum++;
                    pickPizzaType = false;
                    pickPizzaToppings = true;

                    pizzaTypeButtons.SetActive(false);
                    bakeButton.SetActive(true);
                    meatToppingButtons.SetActive(true);
                    veggieToppingButtons.SetActive(true);
                    break;
                case "Pepperoni":
                    this.pizza = new PepperoniPizza();
                    //otalPizzasNum++;
                    pickPizzaType = false;
                    pickPizzaToppings = true;

                    pizzaTypeButtons.SetActive(false);
                    bakeButton.SetActive(true);
                    meatToppingButtons.SetActive(true);
                    veggieToppingButtons.SetActive(true);
                    break;
            }
        }
        DisplayPizza();
    }

    public void AddTopping(string toppingName)
    {
        if (!pickPizzaType)
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
        }
        DisplayPizza();
    }

    public void DisplayPizza()
    {
        pizzaStats.text = pizza.GetDescription() + " with " + pizza.GetTotalPizzaToppings() + " toppings." + " and a total cost of: $" + pizza.GetTotalCost();

        totalCostNum = pizza.GetTotalCost();
    }

    IEnumerator Timer()
    {
        duration = 30;

        yield return new WaitForSeconds(1f);

        while(duration > 0)
        {
            duration -= Time.deltaTime;
            timerText.text = "Timer: " + duration.ToString("00");
            yield return null;
        }

        if (totalCostNum == randomTotalCost)
        {
            gameIsOver = true;
            resultsText.text = "Results\n\nWhatever I want to say here.";
            StopAllCoroutines();
            audioMan.audioSource.Stop();
        }
        else if (totalCostNum < randomTotalCost)
        {
            gameIsOver = true;
            resultsText.text = "Results:\n\nYou underspent and ran out of time! You must bake the pizza!\nYour budget was $" + randomTotalCost + " and you spent $" + totalCostNum;
            StopAllCoroutines();
            audioMan.audioSource.Stop();
        }
        else
        {
            gameIsOver = true;
            resultsText.text = "Results:\n\nYou overspent and ran out of time! You must bake the pizza!\nYour budget was $" + randomTotalCost + " and you spent $" + totalCostNum;
            StopAllCoroutines();
            audioMan.audioSource.Stop();
        }
    }

    public void StartGame()
    {
        if(!canPlay)
        {
            pizzaStats.text = "It's Pizza Time!!";
            randomTotalCost = Random.Range(10, 40);
            canPlay = true;
            startGameButton.interactable = true;
            cheesePizzaButton.interactable = true;
            sausagePizzaButton.interactable = true;
            pepperoniPizzaButton.interactable = true;
            audioMan.PlayVoice();
            audioMan.PlayGameMusic();
            StartCoroutine(Timer());
        }
    }

    public void GameOver()
    {
        if (totalCostNum == randomTotalCost)
        {
            gameIsOver = true;
            resultsText.text = "Results:\n\nCongratulations you matched the price!";
            StopAllCoroutines();
            audioMan.audioSource.Stop();
        }
        else if(totalCostNum < randomTotalCost)
        {
            gameIsOver = true;
            resultsText.text = "Results:\n\nYou underspent!\nYour budget was $" + randomTotalCost + " and you spent $" + totalCostNum;
            StopAllCoroutines();
            audioMan.audioSource.Stop();
        }
        else
        {
            gameIsOver = true;
            resultsText.text = "Results:\n\nYou overspent!\nYour budget was $" + randomTotalCost + " and you spent $" + totalCostNum;
            StopAllCoroutines();
            audioMan.audioSource.Stop();
        }
    }
}
