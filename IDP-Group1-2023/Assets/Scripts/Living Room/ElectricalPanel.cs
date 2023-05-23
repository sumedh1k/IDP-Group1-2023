using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricalPanel : MonoBehaviour
{
    public GameObject RedButton;
    public GameObject BlueButton;
    public GameObject GreenButton;
    public GameObject YellowButton;
    public GameObject Spotlight;
    public GameObject Diffuser;
    public GameObject RoomBackground;
    public GameObject Couch;
    public GameObject Painting;
    public GameObject Table;
    public GameObject Bookshelf;
    public GameObject LemonTrigger;

    int correctClicked = 0;
    int[] sequence = {4, 3, 1, 1, 3 };

    public void buttonClicked(int identity)
    { 
        Debug.Log("buttonclicked" + identity);
        if (identity == sequence[correctClicked])
        {
            correctClicked++;
            Debug.Log("Correctclick" + correctClicked);
        }
        else
        {
            correctClicked = 0;
            Debug.Log("correct reset");
        }
        if (correctClicked == 5)
        {
            RedButton.SetActive(false);
            BlueButton.SetActive(false);
            GreenButton.SetActive(false);
            YellowButton.SetActive(false);
            Spotlight.SetActive(false);
            Diffuser.SetActive(false);
            RoomBackground.SetActive(false);
            Couch.SetActive(false);
            Painting.SetActive(false);
            Table.SetActive(false);
            Bookshelf.SetActive(false);
            LemonTrigger.SetActive(true);  
        }
    }
}
