using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public AudioClip collectSound;
    public static int charge = 0;
    // Start is called before the first frame update
    void Start()
    {
        charge = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CellPickup()
    {
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        charge++;
    }
}


