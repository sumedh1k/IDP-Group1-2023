using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Linq;

public class LeadboardSubmit : MonoBehaviour
{
    [SerializeField] InputField Username;
    private float totalTime;

    string URL = "https://docs.google.com/forms/d/1SNQXmAySlNG9_TJtQTS7S-0WoRG5qe4dFPJEcfFjSPs/formResponse";

    public void Send()
    {
        totalTime = PlayerPrefs.GetFloat("Room1Time", 0);
        StartCoroutine(Post(Username.text, totalTime.ToString(), totalTime.ToString()));
    }


    IEnumerator Post(string s1, string totalTime, string room1Time)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.90614589", s1); //username
        form.AddField("entry.1966360332", totalTime); //totalTime
        form.AddField("entry.1669616406", totalTime); //room1Time


        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();
    }
}
