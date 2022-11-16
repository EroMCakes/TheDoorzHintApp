using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ViewControllTools
{
    public class ViewController : MonoBehaviour
    {
        private static PanelController panelController;

        public static void LoadViewWithIndex(
            GameObject[] prefabList,
            int viewIndex
        )
        {
            panelController = FindObjectOfType<PanelController>();

            var canvas = panelController.mainCanvas;
            Instantiate(prefabList[viewIndex])
                .transform
                .SetParent(canvas.transform, false);
        }

        public static void DestroyCurrentViewPanel()
        {
            panelController = FindObjectOfType<PanelController>();

            var canvas = panelController.mainCanvas;

            Destroy(canvas.transform.GetChild(0).gameObject);
        }

        public static void DestroyHintPanel()
        {
            panelController = FindObjectOfType<PanelController>();

            var canvas = panelController.mainCanvas;

            Destroy(canvas.transform.GetChild(1).gameObject);
        }

        // public void BackFromHint() {
        //     switch (panelController.challenge) {
        //         case "joker": {
        //             LoadViewWithIndex(panelController.jokerGamePanels, 1);
        //             break;
        //         }
        //     }
        // }
        public void SelectChallenge(string challengeName)
        {
            panelController = FindObjectOfType<PanelController>();

            var canvas = panelController.mainCanvas;

            switch (challengeName)
            {
                case "joker":
                    {
                        panelController.challenge = challengeName;
                        panelController.hint = 0;
                        panelController.step = 0;
                        DestroyCurrentViewPanel();
                        LoadViewWithIndex(panelController.prisonGamePanels, 0);
                        break;
                    }
                case "prison":
                    {
                        panelController.challenge = challengeName;
                        panelController.hint = 0;
                        panelController.step = 0;
                        DestroyCurrentViewPanel();
                        LoadViewWithIndex(panelController.prisonGamePanels, 0);
                        break;
                    }
            }
        }

        public static void LoadJokerViewWithIndex(int viewIndex) =>
            ViewController
                .LoadViewWithIndex(panelController.jokerGamePanels, viewIndex);

        public void StartGame()
        {
            panelController.step = 1;
            
            ViewController.LoadViewWithIndex(panelController.jokerGamePanels, 1);
            // var chrono = FindObjectOfType<CountdownHandler>();
            // StartCoroutine(chrono.Countdown());
            ViewController.DestroyCurrentViewPanel();
            // StartCoroutine(panelController.ShortHintAvailability());
        }

        public void PreviousToPIn() {
            ViewController.DestroyCurrentViewPanel();
            ViewController.LoadViewWithIndex(panelController.mainPanelsPrefabs, 0);
        }

        public void BackToChallengeChoice()
        {
            ViewController.DestroyCurrentViewPanel();
            ViewController
                .LoadViewWithIndex(panelController.mainPanelsPrefabs, 1);
        }
    }
}
