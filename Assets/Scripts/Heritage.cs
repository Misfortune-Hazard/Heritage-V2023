using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heritage
{

    private List<Antique> antique;

    private Antique available;
    
    public Heritage (List<Antique> antiques)
    {
        this.antique = antiques;
    }

    public string BuyItem(int index, Budget budget)
    {
        //if (index < 0 || index >= this.antique.Count) return "Invalid Index";

        Antique product = antique[index];

        budget.PuttingMoney(product.GetPrice());

        product.NoMore();

        //Debug.Log("Remaining money: $" + budget.GetBalance());

        if (!product.Availability())
        {
            return product.GetName() + " sold out.";
        }

        if (!budget.PuttingMoney(product.GetPrice()))
        {
            return "Not enough money.";
        }

        return "Remaining money: $" + budget.GetBalance();
    }

}
