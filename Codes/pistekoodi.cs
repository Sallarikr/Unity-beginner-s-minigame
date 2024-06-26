using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pistekoodi : MonoBehaviour
{
    // Ajan laskeminen
    public float aikalaskuri = 60f;

    // Pisteiden laskeminen
    public float pistelaskuri = 0f;

    // Aika-teksti
    private GameObject teksti1 = null;

    // Pisteet-teksti
    private GameObject teksti2 = null;

    void Start()
    {
        this.teksti1 = GameObject.Find("Aika");
        this.teksti2 = GameObject.Find("Pisteet");
    } // Start

    void Update()
    {
        // Ajan vähentäminen
        this.aikalaskuri -= Time.deltaTime;
        this.teksti1.GetComponent<Text>().text = "AIKA: " + this.aikalaskuri.ToString("0");

        this.teksti2.GetComponent<Text>().text = "PISTEET: " + this.pistelaskuri.ToString("0");

        // Kun aika loppuu
        if (this.aikalaskuri < 0f)
        {
            // Pisteiden siirto
            PlayerPrefs.SetFloat("summa", this.pistelaskuri);

            SceneManager.LoadScene(2);
        }
    } // Update
} // class
