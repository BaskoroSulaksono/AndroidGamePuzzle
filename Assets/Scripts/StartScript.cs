using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScript : MonoBehaviour
{

    public GameObject FinishScreen;
    private int scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(scene);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameFinish.isGameFinished)
        {
            Debug.Log("isgamefinished di startscript");
            if (scene != SceneManager.GetActiveScene().buildIndex)
            {
                FinishScreen.GetComponent<FinishScreen>().RepeatLevel();
            }
        }
    }


    //if gameispaused
    //continue
    //if gameisfinish
    //if another scene , repeat level
}
