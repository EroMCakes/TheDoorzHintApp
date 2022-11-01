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

        panelController.time = 15 / 5;

        var chronoHandler = FindObjectOfType<CountdownHandler>();
        chronoHandler.startTime = 900f;
        
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
            if (panelController.hint == 0)
            {
                StartCoroutine(panelController.ShortHintAvailability());
            }
        }
    }

    public void LoadJokerViewWithIndex(int viewIndex) =>
        ViewController
            .LoadViewWithIndex(panelController.jokerGamePanels, viewIndex);

    public void StartGame()
    {
        panelController.step = 1;

        LoadJokerViewWithIndex(1);
        // StartCoroutine(panelController.ShortHintAvailability());
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
                                }
                                break;
                            }
                    }
                    break;
                }
        }
    }

    public void BackToChallengeChoice() =>
        ViewController.LoadViewWithIndex(panelController.mainPanelsPrefabs, 1);
}
