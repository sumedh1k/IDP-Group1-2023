using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ElevatorHandler: MonoBehaviour, IPointerClickHandler
{
    public TMP_InputField inputField;
    public GameObject[] objectsToActivate;

    public void OnPointerClick(PointerEventData eventData)
    {
        string inputValue = inputField.text;

        // Check the value of the input field
        if (inputValue == "FRIENDS")
        {
            Debug.Log("Correct");
            // Set all objects to active
            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(true);
                
            }
        }
        else
        {
            // Set all objects to inactive
            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(false);

                Debug.Log("Wrong");
            }
        }
    }
}
