using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestination : MonoBehaviour
{
    public string gameObjectTag;
    public GameObject gameObject;
    public GameObject spawnLocation;
    public Inventory inv;
    public bool partCompleted;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && inv.gameObjectTag == gameObjectTag && inv.hasItem)
        {
            spawnObject();
            inv.hasItem = false;
            partCompleted = true;
        }
    }

    private void spawnObject()
    {
        GameObject finalLever = Instantiate(gameObject, spawnLocation.transform.position, spawnLocation.transform.rotation);
    }
}
