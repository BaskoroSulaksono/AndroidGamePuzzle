using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class DragAndDrop : MonoBehaviour
{
    public GameObject selectedPiece;
    int orderInLayer = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // first touch detected
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            // shot raycast to touch
            RaycastHit2D hit = Physics2D.Raycast(touchPosition, Vector2.zero);

            if (hit.collider != null && hit.transform.CompareTag("Puzzle"))
            {
                // initial touch for storing puzzle piece info
                if (touch.phase == TouchPhase.Began)
                {
                    if (!hit.transform.GetComponent<PieceScript>().inOriginPosition)
                    {
                        selectedPiece = hit.transform.gameObject;
                        selectedPiece.GetComponent<PieceScript>().selected = true;
                        selectedPiece.GetComponent<SortingGroup>().sortingOrder = orderInLayer;
                    }
                }
            }

            // touch moved or stationary still hold the pieces
            if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                if (selectedPiece != null)
                {
                    selectedPiece.transform.position = new Vector3(touchPosition.x, touchPosition.y, 0f);
                }
            }

            // touch exit after began or after moved
            if (touch.phase == TouchPhase.Ended)
            {
                if (selectedPiece != null)
                {
                    selectedPiece.GetComponent<SortingGroup>().sortingOrder = 0;
                    selectedPiece.GetComponent<PieceScript>().selected = false;
                    selectedPiece = null;
                }

            }
        }


    }

    //test script
    /*void CobaTouchControl()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("BEGAN");
            }
            if (touch.phase == TouchPhase.Ended)
            {
                Debug.Log("TOUCH ENDED");
            }
            if (touch.phase == TouchPhase.Stationary)
            {
                Debug.Log("Diam Di Tempat");

            }
            if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("Bergerak");
            }
        }
    }*/
}

