using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCShout : MonoBehaviour
{
    //public TMP_Text shoutText;
    private bool hasShoutedAlready;
    private AudioSource audio;
    private void Start()
    {
        audio = GetComponentInParent<AudioSource>();
        //shoutText.GetComponent<TextMeshProUGUI>().enabled = false;
        hasShoutedAlready = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        //shoutText.GetComponent<TextMeshProUGUI>().enabled |= !hasShoutedAlready;
        audio.Play();
        hasShoutedAlready = true;
    }

    private void OnTriggerExit(Collider other)
    {
        audio.Stop();
        //shoutText.GetComponent<TextMeshProUGUI>().enabled = false;
    }
}
