using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class PrisonHandler : MonoBehaviour
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

        panelController.time = 900 / 8;
        panelController.minTemps = 8 * 60;

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

    // Update is called once per frame
    void Update()
    {
        if (panelController.step != currentStep)
        {
            currentStep = panelController.step;
            stepInfo.text = "Etape" + panelController.step + "/4";
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

    public void LoadPrisonHintWithIndex(int hint)
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
                                    HintCheck(hint);
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .prisonHintsPanels,
                                        0);
                                }
                                break;
                            }
                        case 2:
                            {
                                if (panelController.hint > 1)
                                {
                                    HintCheck(hint);
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .prisonHintsPanels,
                                        1);
                                }
                                break;
                            }
                        case 3:
                            {
                                if (panelController.hint > 2)
                                {
                                    HintCheck(hint);
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .prisonHintsPanels,
                                        2);
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
                                    HintCheck(hint);
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .prisonHintsPanels,
                                        3);
                                }
                                break;
                            }
                        case 2:
                            {
                                if (panelController.hint > 1)
                                {
                                    HintCheck(hint);
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .prisonHintsPanels,
                                        4);
                                }
                                break;
                            }
                        case 3:
                            {
                                if (panelController.hint > 2)
                                {
                                    HintCheck(hint);
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .prisonHintsPanels,
                                        5);
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
                                    HintCheck(hint);
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .prisonHintsPanels,
                                        6);
                                }
                                break;
                            }
                        case 2:
                            {
                                if (panelController.hint > 1)
                                {
                                    HintCheck(hint);
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .prisonHintsPanels,
                                        7);
                                }
                                break;
                            }
                        case 3:
                            {
                                if (panelController.hint > 2)
                                {
                                    HintCheck(hint);
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .prisonHintsPanels,
                                        8);
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
                                    HintCheck(hint);
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .prisonHintsPanels,
                                        9);
                                }
                                break;
                            }
                        case 2:
                            {
                                if (panelController.hint > 1)
                                {
                                    HintCheck(hint);
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .prisonHintsPanels,
                                        10);
                                }
                                break;
                            }
                        case 3:
                            {
                                if (panelController.hint > 2)
                                {
                                    HintCheck(hint);
                                    ViewController
                                        .LoadViewWithIndex(panelController
                                            .prisonHintsPanels,
                                        11);
                                }
                                break;
                            }
                    }
                    break;
                }
        }
    }

    public void LoadPinPanel() {
        ViewController.LoadViewWithIndex(panelController.prisonGamePanels, 2);
    }
}
