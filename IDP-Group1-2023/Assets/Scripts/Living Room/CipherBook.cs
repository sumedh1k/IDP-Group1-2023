using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CipherBook : MonoBehaviour
{

    public GameObject CypherBook;

    public void SetActive()
    {
        if (CypherBook != null) 
        { 
            CypherBook.SetActive(false);
            Debug.Log("buttonclicked");

        }

    }
    
}
