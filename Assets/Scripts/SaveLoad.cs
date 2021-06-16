using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public bool[] levelStatus = { true, false, false };


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Test_isi_array(){
        //tampilkan isi
        for (int i = 0; i < levelStatus.Length; i++)
        {
            Debug.Log(levelStatus[i]);
        }
        
    }
}
