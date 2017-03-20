using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundhistoire : MonoBehaviour
{
    private AudioSource sonshistoire;
    public AudioClip histoireun;
    public AudioClip histoiredeux;
    public AudioClip histoiretrois;

    void Start()
    {
        sonshistoire = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Raconte histoire un
        if (other.gameObject.name == "box trigger histoire un")
        {
            sonshistoire.Stop();
            sonshistoire.PlayOneShot(histoireun);
        }

        // Raconte histoire deux
        else if (other.gameObject.name == "box trigger histoire deux")
        {
            sonshistoire.Stop();
            sonshistoire.PlayOneShot(histoiredeux);
        }

        // Raconte histoire trois
        else if (other.gameObject.name == "box trigger histoire trois")
        {
            sonshistoire.Stop();
            sonshistoire.PlayOneShot(histoiretrois);
        }

        // Se tait
        else
        {
            sonshistoire.Stop();
        }

    }


}
