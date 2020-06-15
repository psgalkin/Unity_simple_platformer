using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameLogicScript : MonoBehaviour
{
    [SerializeField]
    private TriggerDetector isInGameScene;
    [SerializeField]
    private TriggerDetector isWin;
    [SerializeField]
    private GameObject EndGameUI;
    [SerializeField]
    private GameObject WinUI;
    [SerializeField]
    private GameObject LossUI;
    [SerializeField]
    private GameObject InGameUI;
    // Start is called before the first frame update
    void Start()
    {
        EndGameUI.SetActive(false);
        WinUI.SetActive(false);
        LossUI.SetActive(false);
        InGameUI.SetActive(true);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInGameScene.InTrigger) {
            loss();
        }
        if (isWin.InTrigger)
        {
            win();
        }
    }

    public void loss()
    {
        Time.timeScale = 0;
        InGameUI.SetActive(false);
        EndGameUI.SetActive(true);
        LossUI.SetActive(true);
    }

    void win()
    {
        Time.timeScale = 0;
        InGameUI.SetActive(false);
        EndGameUI.SetActive(true);
        WinUI.SetActive(true);
    }


    public void StartNewGame()
    {
        WinUI.SetActive(false);
        LossUI.SetActive(false);
        EndGameUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        InGameUI.SetActive(true);
    }
}
