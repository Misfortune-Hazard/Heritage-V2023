using UnityEngine;
using UnityEngine.U2D;

public class Gamer : MonoBehaviour
{
    public string alias;
    public int durability = 35;
    public int sharpness = 12;
    public Sprite adminSprite;
    public SpriteRenderer spriteRenderer;

    public virtual void Cut()
    {
        Debug.Log(alias + " swings, dealing " + sharpness + " damage.");
    }

    public void Uses(int energy)
    {
        durability -= energy;
        Debug.Log("You took a swing, it took " + energy + " energy.");
    }
}

    