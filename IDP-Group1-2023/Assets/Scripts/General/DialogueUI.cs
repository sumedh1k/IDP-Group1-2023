using UnityEngine;
using TMPro;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;

    private void Start()
    {
        GetComponent<TypewriterEffect>().Run("Wh-where am I? I was just playing with the dollhouse a few seconds ago.", textLabel);
    }
}
