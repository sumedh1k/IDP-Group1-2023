using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class Trigger : MonoBehaviour
{
    public GameObject obj;
    public GameObject OpenCipherBook;

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
        obj.SetActive(false);
        isActive = false;
        runTrigger = false;
    }

    protected virtual void toRun()
    {
        obj.SetActive(!isActive); // false to hide, true to show
        isActive = !isActive;
    }

    protected virtual void openBook()
    {
        OpenCipherBook.SetActive(!isActive);
        isActive = !isActive;
    }
}