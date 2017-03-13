using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundpoussette : MonoBehaviour {

    public bool positionbois = false;
    public bool positiongravier = false;
    public bool positionherbe = false;
    public Testposition testpositionscript;

    private AudioSource sons;
    public AudioClip soundbois;
    public AudioClip soundgravier;
    public AudioClip soundherbe;


    void Update () {
        // Récupère sur quoi roule le joueur
        positionbois = testpositionscript.positionbois;
        positiongravier = testpositionscript.positiongravier;
        positionherbe = testpositionscript.positionherbe;

        if (positionbois = true)
            {
                //sons.PlayOneShot(soundbois);
            }
        else if (positionherbe = true)
            {
                //sons.PlayOneShot(soundherbe);
            }
        else if (positiongravier = true)
            {
                //sons.PlayOneShot(soundgravier);
            }
    }

}
