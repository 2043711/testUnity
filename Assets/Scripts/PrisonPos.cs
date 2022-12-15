using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrisonPos : MonoBehaviour
{
    //position de la pi�ce quand elle � �t� mang�
    public Transform positionPrison;
    /// <summary>
    /// Fonction lorsque une pi�ce sort du plateau de jeu
    /// </summary>
    public void outOfMap()
    {
        StartCoroutine(ChangePos());
    }
    /// <summary>
    /// Change la position de la pi�ce vers un point sur la boite apr�s 1 seconde
    /// </summary>
    /// <returns></returns>
    IEnumerator ChangePos()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        transform.rotation = new Quaternion(0, 0, 0, 0);
        yield return new WaitForSecondsRealtime(1);
        transform.position = positionPrison.position;
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
