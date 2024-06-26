using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SceneManager
using UnityEngine.SceneManagement;


public class introkoodi : MonoBehaviour
{
    void Start()
    {
        
    } // Start

    void Update()
    {
        // Kun painetaan mitä vain painiketta
        if(Input.anyKey) {
            SceneManager.LoadScene(1);
        }
    } // Update
} // class
