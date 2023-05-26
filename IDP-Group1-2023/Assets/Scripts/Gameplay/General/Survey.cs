/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class Survey : MonoBehaviour
{

    [SerializeField] InputField feedback1;
    [SerializeField] InputField feedback2;
    [SerializeField] InputField feedback3;
    [SerializeField] InputField feedback4;
    [SerializeField] InputField feedback5;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSforM0ZFPLKcNTqCxeLNVxT-vG1SJRnsF6-oQBnAUxuxb-puw/formResponse";


    public void Send()
    {
        StartCoroutine(Post(feedback1.text));
        StartCoroutine(Post(feedback2.text));
        StartCoroutine(Post(feedback3.text));
        StartCoroutine(Post(feedback4.text));
        StartCoroutine(Post(feedback5.text));
    }

    IEnumerator Post()
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1438025189", ); //Q1
        form.AddField("entry.303991439", s2); //Q2
        form.AddField("entry.169532271", i3); //Q3
        form.AddField("entry.330256318", i4); //Q4
        form.AddField("entry.1498743572", s3); //Q5

        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();

    }

}
*/