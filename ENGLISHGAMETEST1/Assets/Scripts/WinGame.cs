using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    private PlayerController playerController;
    public GameObject warningText;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        playerController = FindObjectOfType<PlayerController>();
        warningText.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (playerController.hasTicket)
                SceneManager.LoadScene("Train Win");

            warningText.SetActive(true);
            audio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        warningText.SetActive(false);
        audio.Stop();
    }
}
