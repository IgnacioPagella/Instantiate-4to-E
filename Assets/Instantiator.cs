using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public Text txtuserCloneAmount;
    public GameObject objectToClone;
    public int cloneAmount;
    
    public void MultiInstantiate()
    {
        if (txtuserCloneAmount.text != "")
        {
            cloneAmount = int.Parse(txtuserCloneAmount.text);
        }
        
        int counter = 0;
        while (counter < cloneAmount)
        {
            Instantiate(objectToClone);
            counter++;
        }

    }
}
