using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    //sementara
    public void LoadLevelNext()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        //jika belum ada level yang di load
        //tambah 2 agar langsung ke index lvl 1
        if (currentScene.buildIndex == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        
        


    }

    
    public void LoadHome()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLevelSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevel(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    //jalankan jika sudah masuk lvl 1
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
