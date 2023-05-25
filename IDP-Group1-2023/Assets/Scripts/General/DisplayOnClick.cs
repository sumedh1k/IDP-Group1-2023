using UnityEngine;
using UnityEngine.UI;

public class DisplayOnClick : MonoBehaviour
{
    public GameObject popup;

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
        isPopupOpen = false;
    }
}