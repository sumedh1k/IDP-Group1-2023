using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfTrigger : MonoBehaviour
{
    public GameObject obj;
    public GameObject ZooButton;
    public GameObject ZooBookSide;
    public GameObject Set1;

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
        Set1.SetActive(false);
        ZooBookSide.SetActive(false);
    }

    protected virtual void toRun()
    {
        obj.SetActive(!isActive); // false to hide, true to show
        ZooButton.SetActive(!isActive);
        ZooBookSide.SetActive(!isActive);
        Debug.Log("Opened");
        isActive = !isActive;
    }
}