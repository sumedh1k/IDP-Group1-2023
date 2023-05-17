using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageHandler : MonoBehaviour
{
    public GameObject Set1;
    public GameObject Set2;
    public GameObject Set3;

    public void NextPage()
    {
        if (Set1.activeSelf)
        {
            Set1.SetActive(false);
            Set2.SetActive(true);
            Debug.Log("Set 1 Inactive");
            Debug.Log("Set 2 Active");
        }
        else if (Set2.activeSelf)
        {
            Set2.SetActive(false);
            Set3.SetActive(true);
            Debug.Log("Set 2 Inactive");
            Debug.Log("Set 3 Active");
        }
       
    }

 
}

