using UnityEngine;
using UnityEngine.U2D;

public class Slashes : MonoBehaviour
{
    public string alias;
    public int durability = 35;
    public int sharpness = 12;
    public Sprite adminSprite;
    public SpriteRenderer spriteRenderer;

    public virtual void Cut()
    {
        Debug.Log(alias + " swings at the tree, dealing " + sharpness + " damage.");
    }

    public void Uses(int energy)
    {
        durability -= energy;
        Debug.Log("You took a swing, it took " + energy + " energy.");
    }

    void Start()
    {
        alias = "Misha";
        sharpness = 12;
        Debug.Log(alias + " on the field!.");
        if (spriteRenderer != null && adminSprite != null)
        {
            spriteRenderer.sprite = adminSprite;
        }
    }

}