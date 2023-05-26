using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZooButton : MonoBehaviour
{
    public GameObject Set1;
    public GameObject NextPage;
    public GameObject CloseButton;

    public void OpenZooBook()
    {

        Debug.Log("Clicked");

        if (Set1 != null)
        {
            Set1.SetActive(true);
            NextPage.SetActive(true);
            CloseButton.SetActive(true);
        }

    }
}
