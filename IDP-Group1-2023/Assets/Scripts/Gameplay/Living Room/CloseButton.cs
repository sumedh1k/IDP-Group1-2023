using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public GameObject Set1;
    public GameObject Set2;
    public GameObject Set3;
    public GameObject CloseButton1;
    public GameObject NextPage;

   public void OnButtonClick()
    {
        Set1.SetActive(false);
        Set2.SetActive(false);
        Set3.SetActive(false);
        CloseButton1.SetActive(false);
        NextPage.SetActive(false);
    }
}
