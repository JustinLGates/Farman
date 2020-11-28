using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendar : MonoBehaviour
{

    float gameTime;
    int season;
    int days;
    int gameHour;
    int gameMinute;
    // Start is called before the first frame update
    void Start()
    {
        gameTime = 86200;
        season = 0;
        days = 29;
        gameHour = 0;
        gameMinute = 0;
        // TODO get time of day from save.
    }

    string s;
    // Updates game time.
    void FixedUpdate()
    {
        gameTime += Time.deltaTime * 5020;

        // changes days and seasons.
        if (gameTime > 86400)
        {
            days += 1;
            gameTime = 0;
            if (days > 30)
            {
                days = 0;
                season += 1;
                if (season>3)
                {
                    season = 0;
                }
            }
        }
        s = gameTimeFormatted();
    }

    // Returns the day formatted d/hh/mm
    public string gameTimeFormatted()
    {
        gameHour = (int) Mathf.Floor( gameTime / 3600);
        gameMinute = (int) Mathf.Floor(((gameTime - (gameHour * 3600))/(60)));
        string addzeroMin = gameMinute > 9 ? "" : "0";
        string addzeroHr = gameHour > 9 ? "" : "0";
        Debug.Log("days - " + days + " "+ gameHour + ":" + addzeroMin + gameMinute);
        return gameHour + ":" + addzeroHr + gameMinute;
    }


}
