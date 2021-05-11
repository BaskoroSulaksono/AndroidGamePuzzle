using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject pieceParent;




    public void FinishTheGame()
    {
        Debug.Log("a");
        GameObject[] pieces;
        pieces = GameObject.FindGameObjectsWithTag("Puzzle");
        foreach (var item in pieces)
        {
            var OriginPos = item.GetComponent<PieceScript>().puzzleOriginPosition;
            item.transform.position = OriginPos;
        }
    }

}
