using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViewControllTools;

public class PanelController : MonoBehaviour
{
   [SerializeField]
   public GameObject[] mainPanelsPrefabs, jokerHintsPanels, jokerGamePanels, prisonGamePanels, prisonHintsPanels, gamePanels, hintPanels;

   public Sprite[] unavailableHintSprites, availableHintSprites;

   public int step, hint, time;

   public string challenge;

   public int totalStep = 1;

   public int score, nH1, nH2, nH3, minTemps;

   public float timeLeft;
   public float totalTime;

   public bool isTaken1 = false;
   public bool isTaken2 = false;
   public bool isTaken3 = false;

   [SerializeField]
   public GameObject mainCanvas;

   private void Awake() {
        ViewController.LoadViewWithIndex(mainPanelsPrefabs, 0);
        
   }

   public IEnumerator ShortHintAvailability() {
    Debug.Log("started Coroutine");
    var button = GameObject.Find("toFirstHint").GetComponent<Button>();
    button.image.sprite = availableHintSprites[0];
    button.image.SetNativeSize();
    ++hint;
    yield return new WaitForSecondsRealtime(time);
    button = GameObject.Find("toSecondHint").GetComponent<Button>();
    button.image.sprite = availableHintSprites[1];
    button.image.SetNativeSize();
    hint = 2;
    yield return new WaitForSecondsRealtime(time);
    button = GameObject.Find("toThirdHint").GetComponent<Button>();
    button.image.sprite = availableHintSprites[2];
    button.image.SetNativeSize();
    hint = 3;
    yield break;
   }


}
