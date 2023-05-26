using UnityEngine;
using UnityEngine.UI;

public class CipherDisplayOnClick : MonoBehaviour
{
    public GameObject popup;
    public GameObject ElevatorTrigger;


    private bool isPopupOpen;

    private void Start()
    {
        // Close the popup at the start
        ClosePopup();
    }

    public void TogglePopup()
    {
        if (isPopupOpen)
        {
            ClosePopup();
            Debug.Log("Popup Closed");
        }
        else
        {
            OpenPopup();
            Debug.Log("Popup Open");
        }
    }

    private void OpenPopup()
    {
        popup.SetActive(true);
        ElevatorTrigger .SetActive(true);
        isPopupOpen = true;
    }

    private void ClosePopup()
    {
        popup.SetActive(false);
        ElevatorTrigger .SetActive(false);
        isPopupOpen = false;
    }
}