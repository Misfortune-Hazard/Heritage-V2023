using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Target
{
    
    public Rock(string name, int health, int damage) : base(name, health, damage) { }

    private void Awake()
    {

        name = "Shard";
        health = 200;
        thorn = 14;

    }

    public override void Retaliate()
    {
        Debug.Log("Shards fly back!");
        transform.localScale = Vector3.one * 2f;
    }

    public override void DoneFor()
    {
        Debug.Log(name + " has been destroyed!");
        transform.localScale = Vector3.zero;
    }

}
