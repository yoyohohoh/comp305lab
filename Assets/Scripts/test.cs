using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Player"))
        //{
            Debug.Log("Sign: Player entered trigger");
        //}
    }

    private void OnTriggerExit(Collider other)
    {
        //if (other.CompareTag("Player"))
        //{
            Debug.Log("Sign: Player exited trigger");
        //}
    }
}
