using UnityEngine;
using UnityEngine.UI;

public class SquirtLemon : MonoBehaviour
{
    public GameObject NewNote;
    public GameObject OldNote;

    public void OnLemonClick()
    {
        OldNote.SetActive(false);
        NewNote.SetActive(true);
    }
}