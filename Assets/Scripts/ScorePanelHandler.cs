using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class ScorePanelHandler : MonoBehaviour
{
    private PanelController panelController;

    [SerializeField]
    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        panelController = FindObjectOfType<PanelController>();
        scoreText.text = "Score: " + panelController.score.ToString();
    }

    public void BackFromScore() {
        panelController.step = 0;
        panelController.nH1 = 0;
        panelController.nH2 = 0;
        panelController.nH3 = 0;
        panelController.timeLeft = 0;
        panelController.totalStep = 1;
        panelController.totalTime = 0;
        panelController.challenge = "";
        panelController.isTaken1 = false;
        panelController.isTaken2 = false;
        panelController.isTaken3 = false;
        ViewController.DestroyCurrentViewPanel();
        ViewController.LoadViewWithIndex(panelController.jokerGamePanels,0);
    }
}
