using UnityEngine;
using UnityEngine.U2D;

public class Slashes : Gamer
{
    public Sprite slashSprite;
    public Switcheroo menu = new Switcheroo();

    public override void Cut()
    {
        base.Cut();
        Debug.Log(alias + " swings, dealing " + sharpness + " damage!");
        transform.localScale = Vector3.one * 1.1f;
    }

    public void Cut(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Debug.Log((i + 1) + " attack ");
        }
    }

    public void Cut(string target)
    {
        Debug.Log(alias + " attacked " + target + "!");
    }

    void Start()
    {
        alias = "Misha";
        sharpness = 12;
        Debug.Log(alias + " on the field!.");
        if (spriteRenderer != null && slashSprite != null)
        {
            spriteRenderer.sprite = slashSprite;
        }
    }

}