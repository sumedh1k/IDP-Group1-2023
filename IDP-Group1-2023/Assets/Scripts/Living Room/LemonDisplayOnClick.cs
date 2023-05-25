using UnityEngine;
using UnityEngine.UI;

public class LemonDisplayOnClick : MonoBehaviour
{
    public GameObject popup;
    public GameObject popup2;

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
        isPopupOpen = true;
    }

    private void ClosePopup()
    {
        popup.SetActive(false);
        popup2.SetActive(false);
        isPopupOpen = false;
    }
}