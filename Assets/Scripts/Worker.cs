using UnityEngine;

public class Worker : Slashes
{
    public Sprite workerSprite;

    public override void Cut()
    {
        Debug.Log(alias + " swings at the tree, it dealt " + sharpness + " damage!");
        transform.localScale = Vector3.one * 1.1f;
    }

    void Start()
    {
        alias = "Adalbert";
        sharpness = 10;

        if(spriteRenderer != null && workerSprite != null)
        {
            spriteRenderer.sprite = workerSprite;
        }
    }

}
