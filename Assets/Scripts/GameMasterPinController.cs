using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class GameMasterPinController : MonoBehaviour
{
    [SerializeField]
    private Text pinField;

    private PanelController panelController;

    public void enterDigit(int enteredNumber) {
        if(pinField.text == "ENTER PIN") pinField.text = "";
        pinField.text += enteredNumber.ToString();
    }

    public void ResetPinField() => pinField.text = "";

    public void ValidatePinField() {
        if(pinField.text == "1605") {
            panelController = FindObjectOfType<PanelController>();
            panelController.hint = 0;
            panelController.step = 0;
            ViewController.DestroyCurrentViewPanel();
            ViewController.LoadViewWithIndex(panelController.gamePanels,0);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
