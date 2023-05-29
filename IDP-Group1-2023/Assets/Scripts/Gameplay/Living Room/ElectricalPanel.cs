using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ElectricalPanel : MonoBehaviour
{
    public GameObject RedButton;
    public GameObject BlueButton;
    public GameObject GreenButton;
    public GameObject YellowButton;
    public GameObject BookshelfInteraction;
    public GameObject Spotlight;
    public GameObject Diffuser;
    public GameObject RoomBackground;
    public GameObject Couch;
    public GameObject Painting;
    public GameObject Table;
    public GameObject DarkAnna;
    public GameObject Bookshelf;
    public GameObject LemonTrigger;
    public GameObject LemonNote;
    public bool Set1Completed;
    public int HintIndex;
    public Flowchart flowchart;

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
            DarkAnna.SetActive(false);
            Painting.SetActive(false);
            Table.SetActive(false);
            Bookshelf.SetActive(false);
            LemonTrigger.SetActive(true);  
            LemonNote.SetActive(true);

            if (flowchart != null)
            {
                flowchart.SetBooleanVariable("Set1Completed", true);
                Debug.Log(flowchart.GetBooleanVariable("Set1Completed"));

                flowchart.SetIntegerVariable("HintIndex", 4);
                Debug.Log(flowchart.GetIntegerVariable("HintIndex"));
                
            }
        }
    }
}
