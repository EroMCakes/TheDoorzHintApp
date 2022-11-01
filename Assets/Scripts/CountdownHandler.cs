using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownHandler : MonoBehaviour
{
    public float startTime = 3600f;
    public Text timerText;

    private PanelController panelController;

    private float timer;

    public IEnumerator Countdown() {
        timer = startTime;

        do {
            timer -= Time.deltaTime;
            FormatText();
            panelController.timeLeft = timer;
            yield return null;
        } while (timer > 0);
    }

    private void Start() {
        panelController = FindObjectOfType<PanelController>();

        if (startTime != panelController.timeLeft) {
            timer = panelController.timeLeft;
        }

        StartCoroutine(Countdown());
    }

    private void FormatText() {
        int M = (int)(timer / 60) % 60;
        int S = (int)(timer / 60);

        timerText.text = "";

        if ( ((int)(timer / 60) % 60) > 9)
        {
            if ((int)(timer % 60) > 9)
            {
                timerText.text += M +":" + S;
            }

            else if ((int)(timer % 60) <= 9)
            {
                timerText.text += M + ":0" + S;
            }
        }

        else if (((int)(timer / 60) % 60) <= 9)
        {
            if ((int)(timer % 60) > 9)
            {
                timerText.text += "0" + M + ":" + S;
            }

            else if ((int)(timer % 60) <= 9)
            {
                timerText.text += "0" + M + ":0" + S;
            }
        }
    }
}
