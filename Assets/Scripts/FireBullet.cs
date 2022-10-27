using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Inspiré par le tutoriel de Fist-Full-Of-Shrimp, video numero 2
//tout en suivant son tutoriel, jai re-utilisé le mon model de fusil pour le cours d'Animation et l'ajout de son
//Déclarion de la classe, Vitesse des balles, position ou sont tiré, utilisation d'un game object pour faire les balles.
public class FireBullet : MonoBehaviour
{
    public float speed = 50f;
    public GameObject bulletObj;
    public Transform frontOfGun;
 
    public static event Action GunFired;
    public void Fire()
    {   
        //Appeler en ordre, le son, spawned bullet et la position, les balles on un rigibody finalment la disparition des balles apres 5 "frame"
        GetComponent<AudioSource>().Play();
        GameObject spawnedBullet = Instantiate(bulletObj, frontOfGun.position, frontOfGun.rotation);
        spawnedBullet.GetComponent<Rigidbody>().velocity = speed * frontOfGun.forward;
        Destroy(spawnedBullet, 5f);
        GunFired?.Invoke();
    }


}
