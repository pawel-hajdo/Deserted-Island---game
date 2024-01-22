using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{
    public Text textHints;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider theObject)
    {
        if (theObject.gameObject.tag == "Player")
        {
            textHints.SendMessage("ShowHint", "Zosta³eœ zagryziony przez wilka \n powrót do menu");
            StartCoroutine("Menu");
        }
    }

    IEnumerator Menu()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("Menu");
    }
}
