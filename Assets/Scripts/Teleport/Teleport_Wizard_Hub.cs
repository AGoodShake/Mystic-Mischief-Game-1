using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Teleport_Wizard_Hub : MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportTo;
    public GameObject StartTeleporter;
    public bool teleported;
    // public GameObject TeleportHub;
    // public GameObject HubTeleport; 
 
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Teleporter"))
        {
            if (teleported == false)
            {
            Teleport();
            Invoke(nameof(ResetTeleport), 5f);
            }
        }
 
        if (collision.gameObject.CompareTag("SecondTeleporter"))
        {
            if (teleported == false)
            {
            Player.transform.position = StartTeleporter.transform.position;
            teleported = true;
            Invoke(nameof(ResetTeleport), 5f);
            }
        }
   }

   public void Teleport()
   {
        Player.transform.position = TeleportTo.transform.position;
        teleported = true;
   }

   public void ResetTeleport()
   {
        teleported = false;
   }
}
 
