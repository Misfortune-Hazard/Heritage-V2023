using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Target : MonoBehaviour//, IDamage
{

    protected string named;
    protected int health;
    protected int thorn;

    public int Health
    {
        get => health;
        set => Mathf.Clamp(value, 0, 100);
    }

    public void TakeDamage(int thorn)
    {
        if (thorn > 0 )
        {
            Health -= thorn;
            Debug.Log(named + " took " + thorn + " damage!" + health + "HP left!");
        }
        else
        {
            DoneFor();
        }
    }

    public virtual void DoneFor()
    {
        Debug.Log(named + " destroyed!");
        
    }

}
