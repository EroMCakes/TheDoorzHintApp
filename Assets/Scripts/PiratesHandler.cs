using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class PiratesHandler : MonoBehaviour
{
    public Button

            hintButton1,
            hintButton2,
            hintButton3;

    [SerializeField]
    private Text stepInfo;

    private PanelController panelController;

    private int currentStep = 0;
    // Start is called before the first frame update
    void Start()
    {
        panelController = FindObjectOfType<PanelController>();

        panelController.time = 3600 / 16;
        panelController.minTemps = 20 * 60;
        panelController.totalStep = 8;

        var chronoHandler = FindObjectOfType<CountdownHandler>();

        stepInfo.text = "Etape: " + panelController.step + "/8";

        if (panelController.hint == 1)
        {
            hintButton1.image.sprite = panelController.availableHintSprites[0];
            hintButton1.image.SetNativeSize();
        }
        else if (panelController.hint == 2)
        {
            hintButton1.image.sprite = panelController.availableHintSprites[0];
            hintButton1.image.SetNativeSize();
            hintButton2.image.sprite = panelController.availableHintSprites[1];
            hintButton2.image.SetNativeSize();
        }
        else if (panelController.hint == 3)
        {
            hintButton1.image.sprite = panelController.availableHintSprites[0];
            hintButton1.image.SetNativeSize();
            hintButton2.image.sprite = panelController.availableHintSprites[1];
            hintButton2.image.SetNativeSize();
            hintButton3.image.sprite = panelController.availableHintSprites[2];
            hintButton3.image.SetNativeSize();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (panelController.step != currentStep)
        {
            currentStep = panelController.step;
            stepInfo.text = "Etape " + panelController.step.ToString() + "/8";
            if (panelController.hint == 0)
            {
                StartCoroutine(panelController.ShortHintAvailability());
                stepInfo.text = "Etape " + panelController.step.ToString() + "/8";
            }
        }
    }

    public void LoadPirateHintWithIndex(int hint) {
        switch (panelController.step) {
            case 1: {
                switch(hint) {
                    case 1: {
                        if(panelController.hint>0) {
                            panelController.nH1 = 1;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 0);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            panelController.nH2 = 1;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 1);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 2) {
                            panelController.nH3 = 1;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 2);
                        }
                        break;
                    }
                }
                break;
            }
            case 2: {
                switch(hint) {
                    case 1: {
                        if(panelController.hint > 0 ) {
                            panelController.nH1 = 2;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 3);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            panelController.nH2 = 2;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 4);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 2) {
                            panelController.nH3 = 2;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 5);
                        }
                        break;
                    }
                }
                break;
            }
            case 3: {
                switch(hint) {
                    case 1: {
                        if(panelController.hint > 0 ) {
                            panelController.nH1 = 3;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 6);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            panelController.nH2 = 3;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 7);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 2) {
                            panelController.nH3 = 3;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 8);
                        }
                        break;
                    }
                }
                break;
            }
            case 4: {
                switch(hint) {
                    case 1: {
                        if(panelController.hint > 0 ) {
                            panelController.nH1 = 4;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 9);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            panelController.nH2 = 4;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 10);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 1) {
                            panelController.nH3 = 4;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 11);
                        }
                        break;
                    }
                }
                break;
            }
            case 5: {
                switch(hint) {
                    case 1: {
                        if(panelController.hint > 0 ) {
                            panelController.nH1 = 5;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 12);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            panelController.nH2 = 5;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 13);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 2) {
                            panelController.nH3 = 5;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 14);
                        }
                        break;
                    }
                }
                break;
            }
            case 6: {
                switch(hint) {
                    case 1: {
                        if(panelController.hint > 0 ) {
                            panelController.nH1 = 6;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 15);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 0 ) {
                            panelController.nH2 = 6;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 16);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 0 ) {
                            panelController.nH3 = 6;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 17);
                        }
                        break;
                    }
                }
                break;
            }
            case 7: {
                switch(hint) {
                    case 1: {
                        if(panelController.hint > 0 ) {
                            panelController.nH1 = 7;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 18);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            panelController.nH2 = 7;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 19);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 2) {
                            panelController.nH3 = 7;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 20);
                        }
                        break;
                    }
                }
                break;
            }
            case 8: {
                switch(hint) {
                    case 1: {
                        if(panelController.hint > 0 ) {
                            panelController.nH1 = 8;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 21);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            panelController.nH2 = 8;
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 22);
                        }
                        break;
                    }
                }
                break;
            }
        }
    }

    public void LoadPinPanel() {
        ViewController.LoadViewWithIndex(panelController.gamePanels, 2);
    }
}
