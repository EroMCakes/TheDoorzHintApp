using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class JokerHandler : MonoBehaviour
{
    public Button

            hintButton1,
            hintButton2,
            hintButton3;

    [SerializeField]
    private Text stepInfo;

    private PanelController panelController;

    private int currentStep = 0;

    private void Start()
    {
        panelController = FindObjectOfType<PanelController>();

        panelController.time = 900 / 8;
        // panelController.hint = 1;
        panelController.minTemps = 8 * 60;
        panelController.totalStep = 4;

        var chronoHandler = FindObjectOfType<CountdownHandler>();

        stepInfo.text = "Etape: " + panelController.step + "/4";

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

    private void Update()
    {
        if (panelController.step != currentStep)
        {
            currentStep = panelController.step;
            stepInfo.text = "Etape: " + panelController.step + "/4";
            if (panelController.hint == 0)
            {
                StartCoroutine(panelController.ShortHintAvailability());
                hintButton2.image.sprite = panelController.unavailableHintSprites[1];
                hintButton3.image.sprite = panelController.unavailableHintSprites[2];
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

    public void LoadJokerHintWithIndex(int hint)
    {
        switch (panelController.step)
        {
            case 1:
                {
                    switch (hint)
                    {
                        case 1:
                            {
                                if (panelController.hint > 0)
                                {
                                    
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .jokerHintsPanels,
                                        0);
                                    HintCheck(1);
                                }
                                break;
                            }
                        case 2:
                            {
                                if (panelController.hint > 1)
                                {
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .jokerHintsPanels,
                                        1);
                                    HintCheck(2);
                                }
                                break;
                            }
                        case 3:
                            {
                                if (panelController.hint > 2)
                                {
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .jokerHintsPanels,
                                        2);
                                    HintCheck(3);
                                }
                                break;
                            }
                    }
                    break;
                }
            case 2:
                {
                    switch (hint)
                    {
                        case 1:
                            {
                                if (panelController.hint > 0)
                                {
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .jokerHintsPanels,
                                        3);
                                    HintCheck(1);
                                }
                                break;
                            }
                        case 2:
                            {
                                if (panelController.hint > 1)
                                {
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .jokerHintsPanels,
                                        4);
                                    HintCheck(2);
                                }
                                break;
                            }
                        case 3:
                            {
                                if (panelController.hint > 2)
                                {
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .jokerHintsPanels,
                                        5);
                                    HintCheck(3);
                                }
                                break;
                            }
                    }
                    break;
                }
            case 3:
                {
                    switch (hint)
                    {
                        case 1:
                            {
                                if (panelController.hint > 0)
                                {
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .jokerHintsPanels,
                                        6);
                                    HintCheck(1);
                                }
                                break;
                            }
                        case 2:
                            {
                                if (panelController.hint > 1)
                                {
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .jokerHintsPanels,
                                        7);
                                    HintCheck(2);
                                }
                                break;
                            }
                        case 3:
                            {
                                if (panelController.hint > 2)
                                {
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .jokerHintsPanels,
                                        8);
                                    HintCheck(3);
                                }
                                break;
                            }
                    }
                    break;
                }
            case 4:
                {
                    switch (hint)
                    {
                        case 1:
                            {
                                if (panelController.hint > 0)
                                {
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .jokerHintsPanels,
                                        9);
                                    HintCheck(1);
                                }
                                break;
                            }
                        case 2:
                            {
                                if (panelController.hint > 1)
                                {
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .jokerHintsPanels,
                                        10);
                                    HintCheck(2);
                                }
                                break;
                            }
                        case 3:
                            {
                                if (panelController.hint > 2)
                                {
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .jokerHintsPanels,
                                        11);
                                    HintCheck(3);
                                }
                                break;
                            }
                    }
                    break;
                }
        }
    }

    public void LoadPinView()
    {
        ViewController.LoadViewWithIndex(panelController.jokerGamePanels, 2);
    }
}
