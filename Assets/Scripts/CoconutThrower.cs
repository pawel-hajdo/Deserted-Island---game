using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class CoconutThrower : MonoBehaviour
{
    public AudioClip throwSound;
    public Rigidbody coconutPrefab;
    public float throwSpeed = 30.0f;
    public static bool canThrow = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1") && canThrow)
        {
            GetComponent<AudioSource>().PlayOneShot(throwSound);
            Rigidbody newCoconut = Instantiate(coconutPrefab, transform.position, transform.rotation) as Rigidbody;
            newCoconut.velocity = transform.forward * throwSpeed;
            //Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), newCoconut.GetComponent<Collider>(), true);
            newCoconut.name = "coconut";
        }
    }
}
