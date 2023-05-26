using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonTrigger : MonoBehaviour
{
    public GameObject LemonTable;
    public GameObject NoLemonTable;
    public GameObject DarkLemonTable;
    public GameObject LemonIcon;
    public GameObject ElevatorTrigger;

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
        isActive = false;
        runTrigger = false;
    }

    protected virtual void toRun()
    {
        LemonTable.SetActive(false);
        DarkLemonTable.SetActive(false);
        NoLemonTable.SetActive(true);
        LemonIcon.SetActive(true);
        ElevatorTrigger.SetActive(true);
        isActive = !isActive;
    }
}