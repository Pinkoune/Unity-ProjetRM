using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPiece : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CollectSystem.leScore += 1;
        Destroy(gameObject);
    }
}
