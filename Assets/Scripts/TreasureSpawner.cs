using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureSpawner : MonoBehaviour
{
    public GameObject treasure;

    void Start()
    {
        Spawn(200);
    }

    public void Spawn(int numberOfTreasures)
    {
        while (numberOfTreasures != 0)
        {
            Instantiate(treasure, new Vector3(Random.Range(0, 2000), 250, Random.Range(0, 2000)), treasure.transform.rotation);
            numberOfTreasures--;
        }
    }

}
