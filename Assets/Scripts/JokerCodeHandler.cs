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
    
    public void PreviousView() {
        var panelController = FindObjectOfType<PanelController>();

        switch (panelController.challenge) {
            case "joker": {
                ViewController.LoadViewWithIndex(panelController.jokerGamePanels, 1);
                break;
            }
        }
    }
    public void ResetCodeField() => codeField.text = "";

    public void ValidateCodeField() {
        switch (codeField.text) {
            case "2479": {
                panelController = FindObjectOfType<PanelController>();
                StopCoroutine(panelController.ShortHintAvailability());
                panelController.step = 2;
                panelController.hint = 0;
                ViewController.LoadViewWithIndex(panelController.jokerGamePanels, 1);
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
                ViewController.LoadViewWithIndex(panelController.jokerGamePanels, 1);
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
                ViewController.LoadViewWithIndex(panelController.jokerGamePanels, 1);
                StartCoroutine(panelController.ShortHintAvailability());
                break;
            }
        }
    }
}
