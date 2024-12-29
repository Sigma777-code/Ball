using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform lastSave;
    private void Start()
    {
        lastSave = gameObject.transform.parent;
        if (lastSave != null)
            Debug.Log(lastSave.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Save"))
        {
            lastSave = other.gameObject.transform;
            Debug.Log("spawn");
        }
    }
    public void Respawn()
    {
            gameObject.transform.position=lastSave.position;
        Debug.Log("spawn");
    }
}
