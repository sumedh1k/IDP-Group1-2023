using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZooButton : MonoBehaviour
{
    public GameObject Set1;

    public void OpenZooBook()
    {

        Debug.Log("Clicked");

        if (Set1 != null)
        {
            Set1.SetActive(true);
        }

    }
}
