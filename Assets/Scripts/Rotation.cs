using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour
{
    //Inspiré par le tutoriel de Roll-a-Ball
    // Avant meme quil y a un changement d'image rendu.
    public void Update()
    {   //Le game Object fait une rotation sur soit, Axe d'Y de 20, multiplié par DeltaTime pour faire en sorte qui soit par seconde aulieu d'image par image
        transform.Rotate(new Vector3(0, 20, 0) * Time.deltaTime);
    }
}
