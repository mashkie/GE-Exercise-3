using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject pickUpText;


    private void Start()
    {
        pickUpText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Medkit"))
        {
            pickUpText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        pickUpText.SetActive(false);
    }
}