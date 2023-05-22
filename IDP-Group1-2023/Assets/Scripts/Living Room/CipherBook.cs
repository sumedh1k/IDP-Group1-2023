using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CipherBook : MonoBehaviour
{
    public GameObject CipherBookObject;
    public GameObject CipherBookSide;

    public void OpenCipherBook()
    {

        Debug.Log("Clicked");

        if (CipherBookSide != null)
        {
            CipherBookObject.SetActive(false);
            CipherBookSide.SetActive(false);
        }

    }
}
