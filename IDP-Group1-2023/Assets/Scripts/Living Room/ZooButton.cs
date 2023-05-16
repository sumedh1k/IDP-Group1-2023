using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZooButton : MonoBehaviour
{
    public GameObject Set1;
  

    // Update is called once per frame
    public void OpenZooBook()
    {
        if (GameObject.Find("Books") != null)
        {
            Set1.SetActive(true);
            NextPage.SetActive(true);
            BackPage.SetActive(true);
        }
    }
}
