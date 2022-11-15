using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdInteraction : MonoBehaviour
{
    private bool inRange;
    private ControlsforPlayer control;

    private void Start()
    {
        control = new ControlsforPlayer();
        control.Enable();
    }
    void Update()
    {
        if(inRange == true && control.Actions.Interact.WasPressedThisFrame())
        {
            BirdAction();
        }
    }

    void BirdAction()
    {
        SceneManager.LoadScene("MainMenu");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inRange = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            inRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inRange = false;
        }
    }
}
