using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class EnemyPicker : MonoBehaviour
{

    [SerializeField] private Color selectedColor = Color.red;
    [SerializeField] private Color usualColor = Color.blue;
    private SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void SelectedMark(bool selected)
    {
        if (sr != null)
        {
            return;
        }
        sr.color = selected ? selectedColor : usualColor;
    }

}
