using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Target : MonoBehaviour, IDamage
{

    public Gamer attack;

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

    void Awake()
    {
        attack = GetComponent<Gamer>();
    }

    public void TakeHit()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health -= thorn;
            Debug.Log(named + " took " + thorn + " damage! " + health + " HP left!");
            if(health <= 0 )
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
