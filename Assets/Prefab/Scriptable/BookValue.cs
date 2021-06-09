using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Sheet", menuName ="Create New Sheet")]
public class BookValue : ScriptableObject
{
    //ini adalah scriptable yang akan berisi data lembaran buku

    //setiap lembar akan berisi
    public new string name;
    public string description;
    public Sprite image;


    //fungsi menampilkan isi 
    public void Print()
    {

    }
}
