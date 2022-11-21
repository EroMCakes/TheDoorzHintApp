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
            stepInfo.text = "Etape " + panelController.step.ToString() + panelController.totalStep.ToString();
            if (panelController.hint == 0)
            {
                StartCoroutine(panelController.ShortHintAvailability());
            }
        }
    }

    public void HintCheck(int hintIndex) {
        switch (hintIndex) {
            case 1: {
                if (!panelController.isTaken1) {
                        panelController.nH1++;
                        panelController.isTaken1 = true;
                }
                break;
            }
            case 2: {
                if (!panelController.isTaken2) {
                    panelController.nH2++;
                    panelController.isTaken2 = true;
                }
                break;
            }
            case 3: {
                if (!panelController.isTaken3) {
                    panelController.nH3++;
                    panelController.isTaken3 = true;
                }
                break;
            }
        }
    }

    public void LoadPirateHintWithIndex(int hint) {
        switch (panelController.step) {
            case 1: {
                switch(hint) {
                    case 1: {
                        if(panelController.hint>0) {
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 0);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 1);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 2) {
                            HintCheck(hint);
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
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 3);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 4);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 2) {
                            HintCheck(hint);
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
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 6);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 7);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 2) {
                            HintCheck(hint);
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
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 9);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 10);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 1) {
                            HintCheck(hint);
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
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 12);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 13);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 2) {
                            HintCheck(hint);
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
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 15);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 0 ) {
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 16);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 0 ) {
                            HintCheck(hint);
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
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 18);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 19);
                        }
                        break;
                    }
                    case 3: {
                        if(panelController.hint > 2) {
                            HintCheck(hint);
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
                            HintCheck(hint);
                            ViewController.LoadViewWithIndex(panelController.hintPanels, 21);
                        }
                        break;
                    }
                    case 2: {
                        if(panelController.hint > 1) {
                            HintCheck(hint);
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
