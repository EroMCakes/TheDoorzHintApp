using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class SherazCodeHandler : MonoBehaviour
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
            case "5561": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 2;
                panelController.hint = 0;
                panelController.isTaken1 = false;
                panelController.isTaken2 = false;
                panelController.isTaken3 = false;
                ResetHintButtons();
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "1954": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 3;
                panelController.hint = 0;
                panelController.isTaken1 = false;
                panelController.isTaken2 = false;
                panelController.isTaken3 = false;
                ResetHintButtons();
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "8846": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 4;
                panelController.hint = 0;
                panelController.isTaken1 = false;
                panelController.isTaken2 = false;
                panelController.isTaken3 = false;
                ResetHintButtons();
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "1054": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 5;
                panelController.hint = 0;
                panelController.isTaken1 = false;
                panelController.isTaken2 = false;
                panelController.isTaken3 = false;
                ResetHintButtons();
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "9430": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 6;
                panelController.hint = 0;
                panelController.isTaken1 = false;
                panelController.isTaken2 = false;
                panelController.isTaken3 = false;
                ResetHintButtons();
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "8437": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 7;
                panelController.hint = 0;
                panelController.isTaken1 = false;
                panelController.isTaken2 = false;
                panelController.isTaken3 = false;
                ResetHintButtons();
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "2440": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 8;
                panelController.hint = 0;
                panelController.isTaken1 = false;
                panelController.isTaken2 = false;
                panelController.isTaken3 = false;
                ResetHintButtons();
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "6650": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 9;
                panelController.hint = 0;
                panelController.isTaken1 = false;
                panelController.isTaken2 = false;
                panelController.isTaken3 = false;
                ResetHintButtons();
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "8580": {
                panelController.step = 10;
                panelController.isTaken1 = false;
                panelController.isTaken2 = false;
                panelController.isTaken3 = false;
                ResetHintButtons();
                StopAllCoroutines();
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
