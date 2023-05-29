using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class ZooButton : MonoBehaviour
{
    public GameObject Set1;
    public GameObject NextPage;
    public GameObject CloseButton;
    public int HintIndex;
    public Flowchart flowchart;

    public void OpenZooBook()
    {

        Debug.Log("Clicked");

        if (Set1 != null)
        {
            Set1.SetActive(true);
            NextPage.SetActive(true);
            CloseButton.SetActive(true);

            if (flowchart != null)
            {
                flowchart.SetIntegerVariable("HintIndex", HintIndex + 1);
                Debug.Log(flowchart.GetIntegerVariable("HintIndex"));
            }
        }

        
    }

}
