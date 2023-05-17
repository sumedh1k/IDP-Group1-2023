using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricalTrigger : MonoBehaviour
{
    public GameObject ElectricalPanel;
    public GameObject RedButton;
    public GameObject BlueButton;
    public GameObject YellowButton;
    public GameObject GreenButton;


    protected bool runTrigger = false;
    protected bool isActive = false;

    protected void Update()
    {
        if (runTrigger)
        {
            if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Space))
            {
                toRun();
            }
        }
    }

    protected void OnTriggerEnter2D(Collider2D other)
    {
        runTrigger = true;
    }

    protected void OnTriggerExit2D(Collider2D other)
    {
        ElectricalPanel.SetActive(false);
        RedButton.SetActive(false);
        BlueButton.SetActive(false);
        YellowButton.SetActive(false);
        GreenButton.SetActive(false);
        isActive = false;
        runTrigger = false;
    }

    protected virtual void toRun()
    {
        ElectricalPanel.SetActive(!isActive); // false to hide, true to show
        RedButton.SetActive(!isActive);
        BlueButton.SetActive(!isActive);
        YellowButton.SetActive(!isActive);
        GreenButton.SetActive(!isActive);
        isActive = !isActive;
    }
}