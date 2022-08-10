using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetecter : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        string newObject = other.gameObject.name;

        if (newObject == "Wall1" || newObject == "Wall2" || newObject == "Roof")
        {
            Debug.Log(newObject + " tiene componente Manager Portal.");
        }
        else if (newObject == "Wall")
        {
            Debug.Log(newObject + " tiene componente Wall Teleport.");
        }
        else
        {
            Debug.Log(newObject + " no tiene ningun componente especifico.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        string newObject = other.gameObject.name;

        if (newObject == "Portal")
        {
            Debug.Log(newObject + " tiene componente Manager Portal.");
        }
    }
}
