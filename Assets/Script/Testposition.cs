using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testposition : MonoBehaviour {

    public bool positionbois =false;
    public bool positionherbe = false;
    public bool positiongravier = false;
    


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("coucou");
        // Est sur du bois
        if (other.gameObject.name == "box trigger bois")
        {

            positionbois = true;
            positionherbe = false;
            positiongravier = false;
        }

        // Est sur de l'herbe ou terre
        else if (other.gameObject.name == "box trigger herbe")
        {
            positionbois = false;
            positionherbe = true;
            positiongravier = false;
        }

        // Est sur du gravier
        else if (other.gameObject.name == "box trigger gravier")
        {
     
            positionbois = false;
            positionherbe = false;
            positiongravier = true;
        }

        else {
            positionbois = false;
            positionherbe = false;
            positiongravier = false;
        }

    }
}
