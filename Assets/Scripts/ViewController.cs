using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ViewControllTools
{
    public class ViewController : MonoBehaviour {
        private static PanelController panelController;

        public static void LoadViewWithIndex(GameObject[] prefabList, int viewIndex) {
           panelController = FindObjectOfType<PanelController>();

           var canvas = panelController.mainCanvas;

           if(canvas.transform.childCount > 0) {
                Destroy(canvas.transform.GetChild(0).gameObject);
           }

           Instantiate(prefabList[viewIndex]).transform.SetParent(canvas.transform, false);
        }

        public static void DestroyCurrentViewPanel() {
            panelController = FindObjectOfType<PanelController>();

            var canvas = panelController.mainCanvas;

            Destroy(canvas.transform.GetChild(0).gameObject);
        }

        public void BackFromHint() {
            switch (panelController.challenge) {
                case "joker": {
                    LoadViewWithIndex(panelController.jokerGamePanels, 1);
                    break;
                }
            }
        }

        public void SelectChallenge(string challengeName) {
            panelController = FindObjectOfType<PanelController>();
            
            var canvas = panelController.mainCanvas;

            switch (challengeName) {
                case "joker": {
                    panelController.challenge = challengeName;
                    panelController.hint = 0;
                    panelController.step = 0;
                    LoadViewWithIndex(panelController.jokerGamePanels, 0);        
                    break;
                }
                case "prison": {
                    panelController.challenge = challengeName;
                    panelController.hint = 0;
                    panelController.step = 0;
                    LoadViewWithIndex(panelController.prisonGamePanels, 0);        
                    break;
                }
            }
        }
    }
}
