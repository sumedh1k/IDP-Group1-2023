using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInput : MonoBehaviour
{
    public GameObject Button;
    public InputField inputField;

    public void InputUsername()
    {
        // Access the placeholder text component
        Text placeholderText = inputField.placeholder.GetComponent<Text>();

        // Get the preferred width of the placeholder
        float placeholderWidth = placeholderText.preferredWidth;

        if (placeholderWidth == 0)
        {
            Button.SetActive(true);
        }
    }

}
