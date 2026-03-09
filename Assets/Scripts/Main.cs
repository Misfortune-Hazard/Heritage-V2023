using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Main : MonoBehaviour
{
    private Heritage pawnShop;
    private Budget userBudget;

    public float money = 50000f;

    private void Start()
    {
        Antique ring = new Antique("Gold Ring", 7, 1500f);
        Antique collar = new Antique("Pearl Collar", 19, 800f);
        Antique dress = new Antique("Royalty Dress", 3, 47500f);

        List<Antique> antiques = new List<Antique> { ring, collar, dress };

        pawnShop = new Heritage(antiques);

        userBudget = new Budget(money);

        Debug.Log("Press 1, 2 or 3 to purchase.");

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log(pawnShop.BuyItem(0, userBudget));
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Debug.Log(pawnShop.BuyItem(1, userBudget));
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Debug.Log(pawnShop.BuyItem(2, userBudget));
        }
    }

}
