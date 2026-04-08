using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Target : MonoBehaviour, IDamage
{

    protected string named;
    protected int health;
    protected int thorn;
    private int damage;

    protected Target(string name, int health, int damage)
    {
        this.name = name;
        this.health = health;
        this.damage = damage;
    }

    public int Health
    {
        get => health;
        set => Mathf.Clamp(value, 0, 100);
    }

    public void TakeHit()
    {
        if (thorn > 0 )
        {
            Health -= thorn;
            Debug.Log(named + " took " + thorn + " damage!" + health + "HP left!");
            if(Health <= 0 )
            {
                DoneFor();
            }
        }
    }

    public abstract void Retaliate();

    public virtual void DoneFor()
    {
        
        Debug.Log(named + " destroyed!");
        gameObject.SetActive(false);
        
    }

}
