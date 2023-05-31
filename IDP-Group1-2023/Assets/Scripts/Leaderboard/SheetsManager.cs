using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using UnityEngine.UI;
using TMPro;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;

public class SheetsManager : MonoBehaviour
{
    static readonly string[] Scopes = { Google.Apis.Sheets.v4.SheetsService.Scope.Spreadsheets };

    static readonly string ApplicationName = "TEAM1DATA";
    static readonly string SpreadsheetID = "1Sl_BQM4EWevJau-oUGbMQI5m972pV1TBJbmHYgFycXo";
    static readonly string sheet = "Sheet1";

    static Google.Apis.Sheets.v4.SheetsService service;

    static public List<string> Usernames = new List<string>();
    static public List<string> Times = new List<string>();

    [SerializeField] TMP_Text Name1;
    [SerializeField] TMP_Text Name2;
    [SerializeField] TMP_Text Name3;
    [SerializeField] TMP_Text Name4;
    [SerializeField] TMP_Text Name5;

    [SerializeField] TMP_Text Time1;
    [SerializeField] TMP_Text Time2;
    [SerializeField] TMP_Text Time3;
    [SerializeField] TMP_Text Time4;
    [SerializeField] TMP_Text Time5;

    private void Update()
    {
        Usernames.Clear();
        Times.Clear();

        Google.Apis.Auth.OAuth2.GoogleCredential credential;

        using (var stream = new FileStream("team1idp-14d019d34c22.json", FileMode.Open, FileAccess.Read))
        {
            credential = Google.Apis.Auth.OAuth2.GoogleCredential.FromStream(stream).CreateScoped(Scopes);
        }

        service = new Google.Apis.Sheets.v4.SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = ApplicationName,


        });

        ReadEntries();
        DisplayLeaderboard();

    }

    static void ReadEntries()
    {
        var range = $"{sheet}!A1:B5";
        var request = service.Spreadsheets.Values.Get(SpreadsheetID, range);

        var response = request.Execute();
        var values = response.Values;

        if (values != null && values.Count > 0)
        {

            foreach (var row in values)
            {
                Usernames.Add($"{row[0]}");
                Times.Add($"{row[1]}");
            }
        }
        else
        {
            Debug.Log("No data was found");
        }
    }

    public void DisplayLeaderboard()
    {


        int minutes1 = Mathf.FloorToInt(float.Parse(Times[0]) / 60);
        int seconds1 = Mathf.FloorToInt(float.Parse(Times[0]) % 60);

        Time1.text = string.Format("{0:00}:{1:00}", minutes1, seconds1);

        int minutes2 = Mathf.FloorToInt(float.Parse(Times[1]) / 60);
        int seconds2 = Mathf.FloorToInt(float.Parse(Times[1]) % 60);

        Time2.text = string.Format("{0:00}:{1:00}", minutes2, seconds2);

        int minutes3 = Mathf.FloorToInt(float.Parse(Times[2]) / 60);
        int seconds3 = Mathf.FloorToInt(float.Parse(Times[2]) % 60);

        Time3.text = string.Format("{0:00}:{1:00}", minutes3, seconds3);

        int minutes4 = Mathf.FloorToInt(float.Parse(Times[3]) / 60);
        int seconds4 = Mathf.FloorToInt(float.Parse(Times[3]) % 60);

        Time4.text = string.Format("{0:00}:{1:00}", minutes4, seconds4);

        int minutes5 = Mathf.FloorToInt(float.Parse(Times[4]) / 60);
        int seconds5 = Mathf.FloorToInt(float.Parse(Times[4]) % 60);

        Time5.text = string.Format("{0:00}:{1:00}", minutes5, seconds5);


        Name1.text = Usernames[0];
        Name2.text = Usernames[1];
        Name3.text = Usernames[2];
        Name4.text = Usernames[3];
        Name5.text = Usernames[4];

        /*Time1.text = Times[0];
        Time2.text = Times[1];
        Time3.text = Times[2];
        Time4.text = Times[3];
        Time5.text = Times[4];
*/
    }
}
