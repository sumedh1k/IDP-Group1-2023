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
        StartCoroutine(Post(feedback1.text, feedback2.text, int.Parse(feedback3.text), int.Parse(feedback4.text), feedback5));
    }

    IEnumerator Post()
    {
        WWWForm form = new WWWForm(string s1, string s2, int num1, int num2, string s3 );
        form.AddField("entry.1438025189", s1); //Q1
        form.AddField("entry.303991439", s2); //Q2
        form.AddField("entry.169532271", num1.ToString()); //Q3
        form.AddField("entry.330256318", num2.ToString()); //Q4
        form.AddField("entry.1498743572", s3); //Q5

        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();

    }

}
*/

using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Linq;

public class Survey : MonoBehaviour
{
    [SerializeField] InputField feedback1;
    [SerializeField] InputField feedback2;
    [SerializeField] ToggleGroup toggleGroup3;
    [SerializeField] ToggleGroup toggleGroup4;
    [SerializeField] InputField feedback5;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSforM0ZFPLKcNTqCxeLNVxT-vG1SJRnsF6-oQBnAUxuxb-puw/formResponse";

    public void Send()
    {
        int value3 = GetToggleGroupValue(toggleGroup3);
        int value4 = GetToggleGroupValue(toggleGroup4);
        StartCoroutine(Post(feedback1.text, feedback2.text, value3, value4, feedback5.text));
    }

    int GetToggleGroupValue(ToggleGroup toggleGroup)
    {
        Toggle activeToggle = toggleGroup.ActiveToggles().FirstOrDefault();
        if (activeToggle != null)
        {
            int index = activeToggle.transform.GetSiblingIndex();
            return index + 1;
        }
        return 0;
    }

    IEnumerator Post(string s1, string s2, int num1, int num2, string s3)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1438025189", s1); //Q1
        form.AddField("entry.303991439", s2); //Q2
        form.AddField("entry.169532271", num1.ToString()); //Q3
        form.AddField("entry.330256318", num2.ToString()); //Q4
        form.AddField("entry.1498743572", s3); //Q5

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();
    }
}
