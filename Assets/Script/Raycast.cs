using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

    Camera camerajoueur;
    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;


    // Use this for initialization
    void Start()
    {
        camerajoueur = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        //déplace la caméra avec la souris
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * -Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);

        //Raycast au centre de l'écran
        int x = Screen.width / 2;
        int y = Screen.height / 2;
        RaycastHit hit;
        Ray ray = camerajoueur.ScreenPointToRay(new Vector3(x, y));
        Debug.DrawRay(ray.origin, ray.direction * 1000, new Color(1f, 0.922f, 0.016f, 1f));

        //Detecte une collision avec le Raycast
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                //Detecte une collision avec le temple & si il est au depart 
                if ((hit.collider.tag == "Temple"))
                {

                }
            }
        }
    }
}
