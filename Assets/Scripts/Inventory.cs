using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public AudioClip collectSound;
    public Texture2D[] hudCharge;
    public RawImage chargeHudGUI;
    public Texture2D[] meterCharge;
    public Renderer meter;
    public static int charge = 0;
    // Zapa³ki
    bool haveMatches = false;
    public RawImage matchHudGUI;
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
        HUDon();
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        charge++;
        chargeHudGUI.texture = hudCharge[charge];
        meter.material.mainTexture = meterCharge[charge];
    }

    void HUDon()
    {
        if (!chargeHudGUI.enabled)
        {
            chargeHudGUI.enabled = true;
        }
    }

    void MatchPickup()
    {
        haveMatches = true;
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        matchHudGUI.enabled = true;
    }
}


