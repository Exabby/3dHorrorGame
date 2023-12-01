using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupLetter : MonoBehaviour
{
    public GameObject collectTextObj, intText, monster;
    public AudioSource pickupSound;
    public bool interactable;
    public static int pagesCollected;
    public Text collectText;

    void Start()
    {
        pagesCollected = 0;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }

    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pagesCollected = pagesCollected + 1;
                if (monster.active == false)
                {
                    monster.SetActive(true);
                }
                collectText.text = pagesCollected + "/8 pages";
                collectTextObj.SetActive(true);
                pickupSound.Play();
                intText.SetActive(false);
                this.gameObject.SetActive(false);
                interactable = false;
            }

        }
    }
}
