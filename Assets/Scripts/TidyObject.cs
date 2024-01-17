using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TidyObject : MonoBehaviour
{
    public float removeTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, removeTime);
    }

    void OnCollisionEnter(Collision theObject)
    {
        if (theObject.gameObject.name == "Terrain")
        {
            gameObject.name = "ground_coconut";
        }
    }
}
