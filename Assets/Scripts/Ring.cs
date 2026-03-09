using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antique
{

    private string items;
    private int amount;
    private float price;

    public Antique(string item, int amounts, float prices)
    {
        this.items = item;
        this.amount = amounts;
        this.price = prices;
    }

    public string GetName()
    {
        return items;
    }

    public int GetAmount()
    {
        amount = amount - 1;
        return amount;
    }

    public float GetPrice()
    {
        return price;
    }

    public bool Availability()

    {
        return amount > 0;
    }

    public void NoMore()
    {
        if(Availability())
        {
            Debug.Log(items + " sold. " + GetAmount() + " left.");
        }
        else
        {
            Debug.Log(items + " sold out.");
        }
    }

}
