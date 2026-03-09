using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Budget
{
    private float actualbalance;
    private float lastTransaction;

    public Budget(float actual)

    {
        if(actual > 0)
        {
            this.actualbalance = actual;
            this.lastTransaction = actual;
        }
        else
        {
            this.actualbalance = 0;
        }
        Debug.Log("Balance del Presupuesto: " + this.actualbalance);
    }

    public float GetBalance()
    {
        return this.actualbalance;
    }

    public void AddBudget(float money)
    {
        if(money >= 0)
        {
            this.actualbalance += money;
        }
        else
        {
            Debug.Log("Invalid transaction, please try again.");
        }
    }

    public bool PuttingMoney(float amounts)
    {
        if (amounts > 0 && amounts <= this.actualbalance)
        {
            this.actualbalance -= amounts;
            Debug.Log("Purchase successful. Current Budget: " + this.actualbalance);
            return true;
        }
        else
        {
            Debug.Log("Purchase failed.");
            return false;
        }
    }

}
