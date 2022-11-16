using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class JokerCodeHandler : MonoBehaviour
{
    [SerializeField]
    private Text codeField;
    private PanelController panelController;

    public void enterDigit(int enteredNumber) {
        if(codeField.text == "ENTER PIN") codeField.text = "";
        codeField.text += enteredNumber.ToString();
    }
    
    public void PreviousView() => ViewController.DestroyHintPanel();
    public void ResetCodeField() => codeField.text = "";

    private void Start() {
        panelController = FindObjectOfType<PanelController>();
    }

    public void ValidateCodeField() {
        switch (codeField.text) {
            case "2479": {
                panelController = FindObjectOfType<PanelController>();
                StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 2;
                panelController.hint = 0;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "1244": {
                panelController = FindObjectOfType<PanelController>();
                if(panelController.hint != 3) {
                    StopCoroutine(panelController.ShortHintAvailability());
                }
                panelController.hint = 0;
                panelController.step = 3;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "3512": {
                panelController = FindObjectOfType<PanelController>();
                if(panelController.hint != 3) {
                    StopCoroutine(panelController.ShortHintAvailability());
                }
                panelController.hint = 0;
                panelController.step = 4;
                ViewController.DestroyHintPanel();
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
            case "666": {
                panelController = FindObjectOfType<PanelController>();
                panelController.step = 5;
                var chrono = FindObjectOfType<CountdownHandler>();
                StopAllCoroutines();
                panelController.score = ((panelController.step - 1) / panelController.totalStep) * ((10 * (panelController.minTemps + (int)(panelController.timeLeft / 60))) - (panelController.nH1 * 3) - (panelController.nH2 * 6) - (panelController.nH3 * 9));
                ViewController.DestroyHintPanel();
                ViewController.DestroyCurrentViewPanel();
                ViewController.LoadViewWithIndex(panelController.mainPanelsPrefabs, 1);
                break;
            }
        }
    }
}
