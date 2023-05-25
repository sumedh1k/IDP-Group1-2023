using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTrigger : MonoBehaviour
{
    public GameObject obj;
   /* public GameObject MainCharacter;
    public GameObject Anna;*/

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
/*        MainCharacter.SetActive(true);
        Anna.SetActive(true);*/
        isActive = false;
        runTrigger = false;
    }

    protected virtual void toRun()
    {
        obj.SetActive(true); // false to hide, true to show
      /*  MainCharacter.SetActive(false);
        Anna.SetActive(false); */  
        isActive = !isActive;
    }
}