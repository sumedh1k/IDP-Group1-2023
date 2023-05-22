using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomTrigger : MonoBehaviour
{
    public GameObject Bedroom;
    public GameObject Hallway;

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
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
        isActive = false;
        runTrigger = false;
    }

    protected virtual void toRun()
    {
        Bedroom.SetActive(true);
        Hallway.SetActive(false);
        isActive = !isActive;
    }
}