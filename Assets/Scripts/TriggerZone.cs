using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public AudioClip lockedSound;
    public Light doorLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if(Inventory.charge == 4)
            {
                transform.Find("door").SendMessage("DoorCheck");
                if (GameObject.Find("PowerGUI"))
                {
                    Destroy(GameObject.Find("PowerGUI"));
                    doorLight.color = Color.green;
                }
            }
            else
            {
                transform.Find("door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
                col.gameObject.SendMessage("HUDon");
            }
        }
    }
}
