using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplaySheet : MonoBehaviour
{
    public BookValue bookValue;

    //refrence to UI
    public Text nameText;
    public Text description;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        //isi dengan scriptable
        nameText.text = bookValue.name;
        description.text = bookValue.description;
        image.sprite = bookValue.image;
    }

    
}
