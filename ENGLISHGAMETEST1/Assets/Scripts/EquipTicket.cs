using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipTicket : MonoBehaviour
{
    private PlayerController player;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player.hasTicket = true;
            player.ShowTicket();
        }

        this.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
