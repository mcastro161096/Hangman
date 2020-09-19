using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureHunter : MonoBehaviour
{
    public ForcaController controller;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Treasure"))
        {
            print("Got treasure! Value = " + collision.gameObject.GetComponent<TreasureData>().Value);
               // controller.treasure += collision.gameObject.GetComponent<TreasureData>().Value;
                    Destroy(collision.gameObject);
        }
            

        
    }


    
}
