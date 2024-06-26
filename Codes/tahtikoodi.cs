using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tahtikoodi : MonoBehaviour
{
    // T‰hden nopeuden arvonta
    private float nopeus = 1f;

    // T‰hden tuhoaminen
    public GameObject pamaus = null;


    void Start()
    {
        // Nopeuden arpominen
        this.nopeus = Random.Range(0.5f, 5f);


    } // Start

    void Update()
    {
        // T‰hden lenn‰tys
        this.GetComponent<Transform>().Translate(-this.nopeus * Time.deltaTime, 0f, 0f);

        // Itsetuho reunojen ulkopuolella
        if (this.GetComponent<Transform>().position.x < -12f)
        {
            Destroy(this.gameObject);
        }
    } // Update

    // Alieniin tˆrm‰ys
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Tˆrm‰t‰‰nkˆ alieniin
        if (collision.name.Equals("alien"))
        {
            // ƒ‰niefekti
            GameObject.Find("Peliaani").GetComponents<AudioSource>()[1].Play();

            // Pistelaskuri
            GameObject.Find("koodivarasto").GetComponent<pistekoodi>().pistelaskuri += 1f;

            // Luodaan pamausanimaatio
            GameObject apupamaus = Instantiate(this.pamaus, this.GetComponent<Transform>().position, Quaternion.identity);

            // R‰j‰hdys tuhoutuu 5 sekunnin p‰‰st‰
            Destroy(apupamaus, 5f);
            Destroy(this.gameObject);
        } // if
    } // OnTriggerEnter2D
} // class
