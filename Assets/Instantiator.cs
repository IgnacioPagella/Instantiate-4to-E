using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public Text txtuserCloneAmount;
    public GameObject objectToClone;
    public int cloneAmount;
    GameObject clon;
    
    public void MultiInstantiate()
    {
        if (txtuserCloneAmount.text != "")
        {
            cloneAmount = int.Parse(txtuserCloneAmount.text);
        }
       
        for (int i = 0; i<cloneAmount; i++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon, 2);
        }

    }
}
