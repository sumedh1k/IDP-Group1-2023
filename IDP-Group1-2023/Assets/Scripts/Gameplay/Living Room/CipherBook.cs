using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CipherBook : MonoBehaviour
{
    public GameObject CipherBookObject;
    public GameObject CipherBookSide;
    public GameObject CipBookInvSpot;

    public void OpenCipherBook()
    {

        Debug.Log("Cipher Book Clicked");

        if (CipherBookSide != null)
        {
            CipherBookObject.SetActive(false);
            CipherBookSide.SetActive(false);
            CipBookInvSpot.SetActive(true);
        }

    }
}
