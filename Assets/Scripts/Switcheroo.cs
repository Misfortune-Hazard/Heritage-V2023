using UnityEngine;

public class Switcheroo : MonoBehaviour
{
    public GameObject slashPrefab;
    public GameObject workerPrefab;

    public Vector3 spawnPoint = new Vector3 (0, 0, 0);

    private GameObject currentChar;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            CharSelection(slashPrefab);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            CharSelection(workerPrefab);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Gamer gamer = currentChar.GetComponent<Slashes>();
            if (gamer != null)
            {
                gamer.Cut();
            }

        }
    }

    void CharSelection(GameObject prefab)
    {
        if (currentChar != null)
        {
            Destroy(currentChar);
        }

        currentChar = Instantiate(prefab, spawnPoint, Quaternion.identity);
        Debug.Log("Now accompanying " + currentChar.name + ", press the Spacebar to start swingin'!");
    }

}
