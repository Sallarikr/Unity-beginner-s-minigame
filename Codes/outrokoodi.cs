using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class outrokoodi : MonoBehaviour
{
    void Start()
    {
        // Pistem‰‰r‰n haku
        float summa = PlayerPrefs.GetFloat("summa");
        GameObject.Find("Teksti").GetComponent<Text>().text = "PISTEESI: " + summa.ToString("0");
    } // Start

    void Update()
    {
        
    } // Update
} // class
