using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundpoussette : MonoBehaviour {

    public bool positionbois = false;
    public bool positiongravier = false;
    public bool positionherbe = false;
   
    private AudioSource sons;
    public AudioClip soundbois;
    public AudioClip soundgravier;
    public AudioClip soundherbe;

    void Start()
    {
        sons = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Est sur du bois
        if (other.gameObject.name == "box trigger bois")
        {
            sons.Stop(soundherbe);
            sons.Stop(soundgravier);
            sons.PlayOneShot(soundbois);
            positionbois = true;
            positionherbe = false;
            positiongravier = false;
        }

        // Est sur de l'herbe ou terre
        else if (other.gameObject.name == "box trigger herbe")
        {
            sons.Stop(soundherbe);
            sons.Stop(soundgravier);
            sons.PlayOneShot(soundherbe);
            positionbois = false;
            positionherbe = true;
            positiongravier = false;
        }

        // Est sur du gravier
        else if (other.gameObject.name == "box trigger gravier")
        {
            sons.Stop();
            sons.PlayOneShot(soundgravier);
            positionbois = false;
            positionherbe = false;
            positiongravier = true;
        }

        //Est a l'arret
        else
        {
            sons.Stop();
            positionbois = false;
            positionherbe = false;
            positiongravier = false;
        }

    }


}
