using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class PieceScript : MonoBehaviour
{
    public Vector3 puzzleOriginPosition;
    public bool inOriginPosition = false;
    public bool selected = false;
    
    // Start is called before the first frame update
    void Start()
    {
        puzzleOriginPosition = transform.position;
        //shuffle pieces random
        ShufflePiece();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,puzzleOriginPosition) < 0.5f)
        {
            if (!selected)
            {
                if (inOriginPosition == false)
                {
                    transform.position = puzzleOriginPosition;
                    inOriginPosition = true;
                    AddCounter();
                    GetComponent<SortingGroup>().sortingOrder = 1;
                    
                }
                
            }
        }
    }

    public void AddCounter()
    {
        GameFinish.counter += 1;
    }

    public void ShufflePiece()
    {
        transform.position = new Vector3(Random.Range(4f, 9f), (Random.Range(2.1f, -3.75f)));
    }

    public void ResetProggress()
    {
        ShufflePiece();
        inOriginPosition = false;
        
    }

    //fungsi sementara nanti diubah
    //mengubah seluruh elemen  pada piece jika tidak lewat menyusun puzzle (hint)
    public void ChangeVarFromEx()
    {
        inOriginPosition = true;
        AddCounter();
        GetComponent<SortingGroup>().sortingOrder = 1;
    }
}
