using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownHandler : MonoBehaviour
{
    public float startTime;

    public Text timerText;

    private PanelController panelController;

    private float timer;

    public IEnumerator Countdown()
    {
        timer = startTime;
        yield return null;

        while (timer > 0)
        {
            timer -= Time.deltaTime;
            panelController.timeLeft = timer;
            // timerText.text = (int)(timer / 60) + ":" + (int)(timer % 60);
            FormatText();
            Debug.Log (timer);
            yield return null;
        }
        if (timer == 0)
        {
            yield break;
        }
        // do {
        //     timer -= Time.deltaTime;
        //     Debug.Log(timer);
        //     FormatText();
        //     yield return null;
        // } while (timer > 0);
    }

    private void Start()
    {
        panelController = FindObjectOfType<PanelController>();
        StartCoroutine(Countdown());
    }

    // private void Start() {
    //     panelController = FindObjectOfType<PanelController>();
    //     if (startTime != panelController.timeLeft) {
    //         timer = panelController.timeLeft;
    //     }
    //     StartCoroutine(Countdown());
    // }
    private void FormatText()
    {
        int M = (int)(timer / 60);
        int S = (int)(timer % 60);

        timerText.text = "";

        if (M > 9)
        {
            if ((int)(timer % 60) > 9)
            {
                timerText.text = M + ":" + S;
            }
            else if ((int)(timer % 60) <= 9)
            {
                timerText.text = M + ":0" + S;
            }
        }
        else if (M <= 9)
        {
            if ((int)(timer % 60) > 9)
            {
                timerText.text = "0" + M + ":" + S;
            }
            else if ((int)(timer % 60) <= 9)
            {
                timerText.text = "0" + M + ":0" + S;
            }
        }
    }
}
