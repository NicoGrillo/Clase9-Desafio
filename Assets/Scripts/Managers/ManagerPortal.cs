using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPortal : MonoBehaviour
{
    public float scaleReduction = 2f;
    bool isBig = true;

    Transform playerTransform;

    void Start()
    {
        isBig = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerTransform = other.gameObject.transform;
        if (playerTransform.CompareTag("Player"))
        {
            Invoke("PlayerScale", 0.5f);
        }

    }

    private void PlayerScale()
    {
        if (isBig == true)
        {
            playerTransform.localScale = playerTransform.localScale / scaleReduction;
        }
        else
        {
            playerTransform.localScale = playerTransform.localScale * scaleReduction;
        }
        isBig = !isBig;
    }

}
