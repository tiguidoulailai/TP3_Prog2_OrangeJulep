using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces : MonoBehaviour
{   
    //declaration de class
    // Vitesse et l'inclusion du RigidBody
    public float speed = 0.01f;
    private Rigidbody rb;

    
    // Départ est appelé avant qu'on met a jour les images rendu
    void Start()
    {   //GetComponent sert a préciser une instance que nous feson référence
        //dans notre cas, Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    // Ce qui est mis a jours, qui donne une image rendu, image par image
    void Update()
    {   
        //debug.logwarning met a jours notre console,confirmant le deplacement

        Debug.LogWarning(transform.position);

        //Utilisation d'une reference de position pour faire pousser le gameobject en question
        //en utilisant un empty object puis sa position, ma permit de majuster (x , y, z)
        Vector3 dest = new Vector3(0f, 0f, -10f);
        
        //Code qui utilise la force pour pousser l'objet
        rb.AddForce(dest * speed, ForceMode.Impulse);
    }
}
