using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienkoodi : MonoBehaviour
{
    // Suunnan kertominen: 1 = oikealle, 2 = vasemmalle
    private int suunta = 1;

    // Hyppyvoiman m‰‰rittely
    private int voima = 450;

    void Start()
    {
        
    } // Start

    void Update()
    {
        // Nuolin‰pp‰ink‰vely

        // Oikealle
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Vaihdetaan tarvittaessa suuntaa
            if (this.suunta == 2)
            {
                this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
                this.suunta = 1;
            } // if
            this.GetComponent<Animator>().SetInteger("alientila", 1);
        } // if

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            this.GetComponent<Animator>().SetInteger("alientila", 0);
        } // if
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<Transform>().Translate(3f * Time.deltaTime, 0f, 0f);
        } // if

        // Vasemmalle
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Vaihdetaan tarvittaessa suuntaa
            if (this.suunta == 1)
            {
                this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
                this.suunta = 2;
            } // if
            this.GetComponent<Animator>().SetInteger("alientila", 1);
        } // if
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            this.GetComponent<Animator>().SetInteger("alientila", 0);
        } // if

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Transform>().Translate(3f * Time.deltaTime, 0f, 0f);
        } // if


        // Hypp‰‰minen
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Hypp‰‰minen toimii vain juostessa
            if(this.GetComponent<Animator>().GetInteger("alientila") == 1)
            {
                this.GetComponent<Animator>().SetInteger("alientila", 2);
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 1f) * this.voima);
            }
        } // if
    } // Update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Hypyst‰ laskeutuessa alien juoksee
        this.GetComponent<Animator>().SetInteger("alientila", 1);
    } // onCollisionEnter2D

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Reunalta pudotessa animaationvaihdos
        this.GetComponent<Animator>().SetInteger("alientila", 2);
    } // onCollisionExit2D

} // class
