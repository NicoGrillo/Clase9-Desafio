using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTeleport : MonoBehaviour
{

    float count = 0;

    private void OnCollisionEnter(Collision other)
    {
        count = 0;
    }

    private void OnCollisionStay(Collision other)
    {
        count += Time.deltaTime;
        if (count >= 2f)
        {
            Vector3 newPosition = new Vector3(Random.Range(-5.0f, 5.0f), 1.10f, Random.Range(-5.0f, 5.0f));
            other.gameObject.transform.position = Vector3.zero + newPosition;
            Debug.Log(other.gameObject.transform.position);
            Quaternion newRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            other.gameObject.transform.rotation = newRotation;
        }
    }
}
