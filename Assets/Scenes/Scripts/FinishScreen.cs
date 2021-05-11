using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScreen : MonoBehaviour
{
    public LevelLoader levelLoader;
    public GameObject controller;
    public GameObject finishScreenUI;
    
    public bool gameIsPaused = false;

    // Update is called once per frame
    void Update()
    {
        if (GameFinish.isGameFinished == true)
        {
            PopFinishScreen();
        }
        
    }

    void PopFinishScreen()
    {
        finishScreenUI.SetActive(true);
       
        controller.GetComponent<HintPuzzle>().SetButtonActive(false);
        controller.GetComponent<ResetPieces>().SetButtonActive(false);

    }

    public void RepeatLevel()
    {
        Debug.Log("c");
        controller.GetComponent<GameFinish>().ResetCounter();
        GameFinish.isGameFinished = false;
        finishScreenUI.SetActive(false);
        ResetProgress();
    }

    void ResetProgress()
    {
        Debug.Log("b");
        controller.GetComponent<HintPuzzle>().SetButtonActive(true);
        controller.GetComponent<ResetPieces>().SetButtonActive(true);
        GameObject[] pieces;
        pieces = GameObject.FindGameObjectsWithTag("Puzzle");
        foreach (var item in pieces)
        {
            item.GetComponent<PieceScript>().ResetProggress();
            //item.transform.position = ;
        }
        controller.GetComponent<HintPuzzle>().ShufflePiecesInArray();
    }

    public void LoadNextLevel()
    {
        Debug.Log("nm");
        levelLoader.LoadNextLevel();
    }
}
