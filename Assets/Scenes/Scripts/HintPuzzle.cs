using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintPuzzle : MonoBehaviour
{
    public GameObject btnHint;
    //int randomGenerateNum = 0;
    public GameObject[] pieces;
    
    //public int pieceLenght;
    private void Start()
    {
        
        pieces = GameObject.FindGameObjectsWithTag("Puzzle");
        ShufflePiecesInArray();
        SetButtonActive(true);
        //pieceLenght = pieces.Length;

    }
    private void Update()
    {
        

    }
//script untuk button hint
//temukan gameobject dengan tag puzzle
//pilih salah satu dari tag puzzle
//posisikan ke original position
//tambah counter



public void HintPieces()
    {
        /*Debug.Log("c");
        randomGenerateNum = Random.Range(0, pieces.Length);
        Debug.Log(randomGenerateNum);
        //randomnya habis duluan
        var selectedPiece = pieces[randomGenerateNum];
        if (selectedPiece.GetComponent<PieceScript>().inOriginPosition)
        {
            randomGenerateNum = Random.Range(0, pieces.Length);
            selectedPiece = pieces[randomGenerateNum];

        }
        if (selectedPiece.GetComponent<PieceScript>().inOriginPosition == false)
        {
            var OriginPos = selectedPiece.GetComponent<PieceScript>().puzzleOriginPosition;
            selectedPiece.transform.position = OriginPos;
            selectedPiece.GetComponent<PieceScript>().ChangeVarFromEx();
        }*/
        
        
        var selectedPiece = pieces[NotInOriginPieces()];
        var OriginPos = selectedPiece.GetComponent<PieceScript>().puzzleOriginPosition;
        selectedPiece.transform.position = OriginPos;
        selectedPiece.GetComponent<PieceScript>().ChangeVarFromEx();
        

    }

    public void ShufflePiecesInArray()
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            var tmp = pieces[i];
            int r = Random.Range(i, pieces.Length);
            pieces[i] = pieces[r];
            pieces[r] = tmp;
        }
    }

    int NotInOriginPieces()
    {
        int indexPiece=0;
        for (int i = 0;i< pieces.Length;i++)
        {
            if (!pieces[i].GetComponent<PieceScript>().inOriginPosition)
            {
                indexPiece = i;
                
            }
        }
        return indexPiece;
    }

   
    public void SetButtonActive(bool param)
    {
        btnHint.SetActive(param);
    }
}
