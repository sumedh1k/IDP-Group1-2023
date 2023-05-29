using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class LemonDisplayOnClick : MonoBehaviour
{
    public GameObject popup;
    public GameObject popup2;

    private bool isPopupOpen;
    public int HintIndex;
    public bool Set2Completed;
    public Flowchart flowchart;

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

        if (flowchart != null)
        {
            flowchart.SetIntegerVariable("HintIndex", 8);
            Debug.Log(flowchart.GetIntegerVariable("HintIndex"));

            flowchart.SetBooleanVariable("Set2Completed", true);
            Debug.Log(flowchart.GetBooleanVariable("Set2Completed"));

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