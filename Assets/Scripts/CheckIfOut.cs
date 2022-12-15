using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfOut : MonoBehaviour
{
    /// <summary>
    /// Regarde si l'objet qui entre dans le collider est une pièce 
    /// si oui lance la fonction "outOfMap()"
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "piece")
        {
            collision.collider.GetComponent<PrisonPos>().outOfMap();
        }
    }
}
