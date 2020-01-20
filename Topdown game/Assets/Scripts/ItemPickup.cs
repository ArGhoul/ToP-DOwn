using UnityEngine;


public class ItemPickup : Interactable
{

    public new GameObject name;

    public Transform hand;

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        Debug.Log("picking up item");

        if (name != null)
        {
            Destroy(name);
            Instantiate(name, hand.position, hand.rotation);
            name.transform.parent = hand.transform;
        }
    }
}
