using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinish : MonoBehaviour
{

    public static int counter = 0;
    public GameObject piecesParent;
    public static bool isGameFinished = false;
    // Start is called before the first frame update
    void Start()
    {
        //GetNumOfChild();
        ResetCounter();
        isGameFinished = false;
    }


    // Update is called once per frame
    void Update()
    {
        
        IsGameFinished();
    }

    //put here
    //jika counter telah menyamai jumlah dari child pieceParent
    //semua puzzle sudah di tempat
    //game selesai
    //pop up
    public void IsGameFinished()
    {
        if(counter == GetNumOfChild())
        {
            isGameFinished = true;
            //Debug.Log("GameFinished");
            //pop up
        }
    }

    public void ResetCounter()
    {
        counter = 0;
    }
    //test script
    //hitung jumlah piece menggunakan getchild
    public int GetNumOfChild()
    {
        int childCount = piecesParent.transform.childCount;
        return childCount;
    }

  
}
