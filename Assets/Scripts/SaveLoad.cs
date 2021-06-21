using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public bool[] levelStatus = { true, false, false };
    
    
    private void Awake()
    {
        // TEST PURPOSE
        SaveObject saveObject = new SaveObject {
            levelStatusObj = levelStatus,
        };
        string json = JsonUtility.ToJson(saveObject);
        Debug.Log(json);

        SaveObject loadedSaveObj = JsonUtility.FromJson<SaveObject>(json);
        for (int i = 0; i < levelStatus.Length; i++)
        {
            levelStatus[i] = loadedSaveObj.levelStatusObj[i];
            Debug.Log(loadedSaveObj.levelStatusObj[i]);
            
        }
        
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // TEST PURPOSE SAVE LOAD USING KEYS
        if (Input.GetKeyDown(KeyCode.S))
        {
            Save();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }
    }

    public void Test_isi_array(){
        //tampilkan isi
        for (int i = 0; i < levelStatus.Length; i++)
        {
            Debug.Log(levelStatus[i]);
        }
        
        
    }
    

    private void Save()
    {
        // Save

    }
    private void Load()
    {

    }


    // json obj going to save
    private class SaveObject
    {
        public bool[] levelStatusObj;
    }
}

