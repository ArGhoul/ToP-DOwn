using UnityEngine;


public class ItemPickup : Interactable
{   

    public new GameObject name;    

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        Debug.Log("picking up item");

        Destroy(name);
        
    }
}
