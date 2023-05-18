using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfTrigger : MonoBehaviour
{
    public GameObject obj;
    public GameObject ZooButton;
    public GameObject ZooBookSide;
    public GameObject Set1;
    public GameObject Set2;
    public GameObject Set3;
    public GameObject NextPage;

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
        Set2.SetActive(false);
        Set3.SetActive(false);
        ZooBookSide.SetActive(false);
        NextPage.SetActive(false);
        ZooButton.SetActive(false);
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