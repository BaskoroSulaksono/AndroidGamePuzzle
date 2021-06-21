using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UILevelSelectHandler : MonoBehaviour
{
    public Button[] Button;
    public SaveLoad saveLoad;
    bool[] levelStatus;

    // Start is called before the first frame update
    void Start()
    {
        levelStatus = saveLoad.levelStatus;
        CheckUnlockedLevel();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void CheckUnlockedLevel()
    {
        for (int i = 0; i < levelStatus.Length; i++)
        {
            
            if (levelStatus[i] == false)
            {
                Button[i].interactable = !Button[i].interactable;
            }

        }
        //cek data playerpref level yang terbuka
        //jika tidak terbuka matikan button

    }
}
