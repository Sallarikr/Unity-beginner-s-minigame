using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tahtienluontikoodi : MonoBehaviour
{
    // Tähden prefab
    public GameObject tahti = null;

    private float laskin = 0;

    void Start()
    {
        
    } // Start

    void Update()
    {
        this.laskin += Time.deltaTime;

        if (this.laskin > 1f)
        {
            // Uusien tähtien luonti
            GameObject aputahti = Instantiate(this.tahti, new Vector3(Random.Range(11f, 13f), Random.Range(-3.4f, 4.55f), 0f), Quaternion.identity);
            this.laskin = 0f;
        } // if
    } // Update
} // class
