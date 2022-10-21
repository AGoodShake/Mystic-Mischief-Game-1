using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class Inventory : MonoBehaviour
{
    ControlsforPlayer controls;
    private Rigidbody rb;
    public List<GameObject> PickedUpItems = new List<GameObject>();
    public GameObject currentHeldItem;
    public Transform HoldItemPosition;

    private bool PickUp;
    private bool Store;
    public bool holdingItem;

    void Awake()
    {
        rb = GetComponentInParent<Rigidbody>();
        controls = new ControlsforPlayer();

    }
    public void OnEnable()
    {
        controls.Enable();
    }
    public void OnDisable() 
    {
        controls.Disable();
    }

    void Start()
    {
        controls.Enable();
    }

    void Update()
    {   
        Store = controls.Inv.Store.IsPressed();
        PickUp = controls.Inv.PressPick.IsPressed();

       /* if (controls.Inv.PressPick.WasPerformedThisFrame())
        {
            PickUp = true;
        }
        if (controls.Inv.Store.WasPerformedThisFrame())
        {
            Store = true;
        }*/

        //Drop the Current Item
        bool Drop = controls.Inv.Drop.ReadValue<float>() > 0.1f;
        if (PickedUpItems.Count > 0 && controls.Inv.Drop.triggered)
        {
            QuickDropStoredItem(PickedUpItems[PickedUpItems.Count - 1]);
        }
        if(holdingItem && PickUp && controls.Inv.PressPick.WasPressedThisFrame())
        {
            DropItem(currentHeldItem);
        }
        if(holdingItem && Store && controls.Inv.Store.WasPressedThisFrame())
        {
            StoreItem(currentHeldItem);
        }
    }
            
    public void QuickDropStoredItem(GameObject Item)
    {
        holdingItem = false;
        rb.mass = rb.mass - Item.GetComponent<Item>().Weight;
        Item.transform.position = transform.position;
        Item.transform.parent = null;
        Item.GetComponent<Rigidbody>().isKinematic = false;
        PickedUpItems.RemoveAt(PickedUpItems.Count - 1); ;
        Item.SetActive(true);
        Item.GetComponent<SphereCollider>().enabled = true;
        Item.GetComponent<BoxCollider>().enabled = true;
    }
    public void StoreItem(GameObject item)
    {
        Debug.Log("Item Stored");
        item.SetActive(false);

        PickedUpItems.Add(item);
        rb.mass = rb.mass + item.GetComponent<Item>().Weight;

    }
    public void HoldItem(GameObject Item)
    {
        Item.GetComponent<SphereCollider>().enabled = false;
        Item.GetComponent<BoxCollider>().enabled = false;
        Item.transform.parent = gameObject.transform;
        Item.transform.position = HoldItemPosition.position;
        Item.GetComponent<Rigidbody>().isKinematic = true;
        holdingItem = true;
        currentHeldItem = Item;
    }
    public void DropItem(GameObject Item)
    {
        Item.GetComponent<SphereCollider>().enabled = true;
        Item.GetComponent<BoxCollider>().enabled = true;
        Item.transform.parent = null;
        Item.GetComponent<Rigidbody>().isKinematic = false;
        currentHeldItem = null;

        StartCoroutine(dropTimer(0.5f,false));
    }
    IEnumerator dropTimer(float time, bool value)
    {
        yield return new WaitForSeconds(time);
        holdingItem = value;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "PickUp" && Store && holdingItem == false)
        {
            StoreItem(other.gameObject);
        }
        if (other.gameObject.tag == "PickUp" && PickUp && holdingItem == false)
        {
            HoldItem(other.gameObject);
        }
        if (other.gameObject.tag == "Goal")
        {
            for (var i = 0; i < PickedUpItems.Count; i++)
            {
                PickedUpItems.RemoveAt(i);
            }
        }
    }
}
