using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeDifficult : MonoBehaviour
{
    public string easySceneLevel, mediumSceneLevel;
    private string nextScene;
    public Text btnDifficult;
    //TEST SCRIPT
    private void Start()
    {
        UpdateUI();
    }
    public void ChangeDiff()
    {
        // checking current scene
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == easySceneLevel)
        {
            nextScene = mediumSceneLevel;
        }
        else
        {
            nextScene = easySceneLevel;
        }
        SceneManager.LoadScene(nextScene);
        
    }
    public void UpdateUI()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == easySceneLevel)
        {
            btnDifficult.text = "Easy";
        }
        else
        {
            btnDifficult.text = "Medium";
        }
    }
    
}
