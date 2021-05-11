using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPieces : MonoBehaviour
{
    public GameObject btnReset;
    public GameObject[] pieces;
    // Start is called before the first frame update
    void Start()
    {
        pieces = GameObject.FindGameObjectsWithTag("Puzzle");
        SetButtonActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*int NotInOriginPieces()
    {
        int[] indexPiece =null;
        for (int i = 0; i < pieces.Length; i++)
        {
            if (!pieces[i].GetComponent<PieceScript>().inOriginPosition)
            {
                indexPiece[i] = i;

            }
        }
        return indexPiece;
    }*/

    public void ResetNotOriginPieces()
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            if (!pieces[i].GetComponent<PieceScript>().inOriginPosition)
            {
                pieces[i].GetComponent<PieceScript>().ShufflePiece();
            }
        }

    }

    public void SetButtonActive(bool param)
    {
        btnReset.SetActive(param);
    }
}
