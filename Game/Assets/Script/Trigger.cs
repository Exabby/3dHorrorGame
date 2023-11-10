using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Add this line for scene management

public class Trigger : MonoBehaviour
{
    public GameObject JumpScareImg;
    public AudioSource audioSource;
    private bool isPlayed = false;

    void Start()
    {
        JumpScareImg.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            if (!isPlayed)
            {
                JumpScareImg.SetActive(true);
                audioSource.Play();
                StartCoroutine(RestartGame());
                isPlayed = true;
            }
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(3); // Adjust the delay as needed
        JumpScareImg.SetActive(false);
        yield return new WaitForSeconds(1); // Add a small delay if needed
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Trigger : MonoBehaviour
// {
//     public GameObject JumpScareImg;
//     public AudioSource audioSource;

//     private bool isPlayed = false;
//     // Start is called before the first frame update
//     void Start()
//     {
//         JumpScareImg.SetActive(false);
//     }

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.gameObject.tag == "Player")
//             if (!isPlayed)
//             {
//                 JumpScareImg.SetActive(true);
//                 audioSource.Play();
//                 StartCoroutine(DisableImg());
//                 isPlayed = true;
//             }
//     }
//     IEnumerator DisableImg()
//     {
//         yield return new WaitForSeconds(3);
//         JumpScareImg.SetActive(false);
//     }
// }


