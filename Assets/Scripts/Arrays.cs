using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrays : MonoBehaviour
{
    string[] array1 = new string[4];
    float[] array2 = new float[4] { 1f, 2f, 3f, 4f };
    int[] array3 = new int[4] { 1, 2, 3, 4 };
    GameObject[] array4 = new GameObject[4];


// Start is called before the first frame update
void Start()
{
    foreach (float array2f in array2)
        {
            Debug.Log("Array2: " + array2f);
        }
        Debug.Log("Array1: " + array1.Length);
        array3[1] = 2;
        array3[2] = 1;
        array4 = GameObject.FindGameObjectsWithTag("RedImage");
        array4[0].GetComponent<Image>().color = Color.red;
    }
}


/* 4 Werte überall
 * 1) Durchlaufen ausgeben der Werte
 * 2) Länge des Arrays ausgeben als Debug
 * 3) 2 Werte Direkt ändern
 * 
 * 4) GameObjects Images anlegen, Tag vergeben, zuweisen und Farbe ändern.*/
