using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Target, I2nteract, IDamage
{
    public Target dmg;

    public Rock(string name, int health, int damage) : base(name, health, damage) { }

    private void Awake()
    {

        name = "Shard";
        health = 100;
        thorn = 14;
        dmg = GetComponent<Target>();

    }

    public override void Retaliate()
    {
        Debug.Log("Shards fly back!");
        transform.localScale = Vector3.one * 2f;
    }

    public override void DoneFor()
    {
        Debug.Log(name + " has been destroyed!");
        //transform.localScale = Vector3.zero;
        Destroy (gameObject);
    }

    private void Update()
    {
        dmg.TakeHit();
    }

}