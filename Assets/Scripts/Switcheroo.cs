using UnityEngine;

public class Switcheroo : MonoBehaviour
{
    public GameObject adminPrefab;
    public GameObject workerPrefab;

    public Vector3 spawnPoint = new Vector3 (0, 0, 0);

    private GameObject currentChar;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            CharSelection(adminPrefab);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            CharSelection(workerPrefab);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Slashes slashes = currentChar.GetComponent<Slashes>();
            if (slashes != null)
            {
                slashes.Cut();
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
