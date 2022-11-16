using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class HoghwartsCodeController : MonoBehaviour
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

    public void ValidateCodeField() {
        switch (codeField.text) {
            case "934": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 2;
                panelController.hint = 0;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "2514": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 3;
                panelController.hint = 0;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "466": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 4;
                panelController.hint = 0;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "6532": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 5;
                panelController.hint = 0;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "2250": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 6;
                panelController.hint = 0;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "7712": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 7;
                panelController.hint = 0;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "9678": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 8;
                panelController.hint = 0;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "832": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 9;
                panelController.hint = 0;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "1996": {
                if(panelController.hint != 3) StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 10;
                panelController.hint = 0;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "1105": {
                panelController.step = 11;
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
