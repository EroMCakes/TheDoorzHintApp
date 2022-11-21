using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class PrisonCodeController : MonoBehaviour
{
    [SerializeField]
    private Text codeField;
    private PanelController panelController;

    public void EnterDigit(int enteredNumber) {
        if(codeField.text == "ENTER PIN") codeField.text = "";
        codeField.text += enteredNumber.ToString();
    }

    public void ResetCodeField() => codeField.text = "";

    public void PreviousView() => ViewController.DestroyHintPanel();

    private void ResetHintButtons() {
        GameObject.Find("toSecondHint").GetComponent<Button>().image.sprite = panelController.unavailableHintSprites[1];
        GameObject.Find("toSecondHint").GetComponent<Button>().image.SetNativeSize();
        GameObject.Find("toThirdHint").GetComponent<Button>().image.sprite = panelController.unavailableHintSprites[2];
        GameObject.Find("toThirdHint").GetComponent<Button>().image.SetNativeSize();
    }

    public void ValidateCodeField() {
        switch (codeField.text) {
            case "3211": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                ResetHintButtons();
                panelController.step = 2;
                panelController.hint = 0;
                panelController.isTaken1 = false;
                panelController.isTaken2 = false;
                panelController.isTaken3 = false;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "7239": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                ResetHintButtons();
                panelController.step = 3;
                panelController.hint = 0;
                panelController.isTaken1 = false;
                panelController.isTaken2 = false;
                panelController.isTaken3 = false;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "5001": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                ResetHintButtons();
                panelController.step = 4;
                panelController.hint = 0;
                panelController.isTaken1 = false;
                panelController.isTaken2 = false;
                panelController.isTaken3 = false;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "9811": {
                panelController.step = 5;
                panelController.isTaken1 = false;
                panelController.isTaken2 = false;
                panelController.isTaken3 = false;
                StopAllCoroutines();
                ResetHintButtons();
                panelController.score = ((panelController.step - 1) / panelController.totalStep) * ((10 * (panelController.minTemps + (int)(panelController.timeLeft / 60))) - (panelController.nH1 * 3) - (panelController.nH2 * 6) - (panelController.nH3 * 9));
                ViewController.DestroyHintPanel();
                ViewController.DestroyCurrentViewPanel();
                ViewController.LoadViewWithIndex(panelController.mainPanelsPrefabs, 1);
                break;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        panelController = FindObjectOfType<PanelController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
