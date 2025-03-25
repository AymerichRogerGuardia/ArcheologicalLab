using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarMuestra : MonoBehaviour
{
    private BoxCollider bc;
    [SerializeField] private DoorController door;
    private bool isMustra = false;

    [SerializeField] private GameObject polen;
    private void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if (door.GetSemIsOpen() && isMustra)
        {
            polen.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Muestra")
        {
            isMustra = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Muestra")
        {
            isMustra = false;
        }
    }
}
