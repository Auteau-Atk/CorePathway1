using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public ItemDestination itemDestination;

    private void Update()
    {
        if(itemDestination.partCompleted)
        {
            Debug.Log("Take a break");
            itemDestination.partCompleted = false;
        }
    }
}
