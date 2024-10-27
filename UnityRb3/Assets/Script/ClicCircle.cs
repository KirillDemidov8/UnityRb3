using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicCircle : MonoBehaviour
{
    [SerializeField] private Bootstrapper bootstrapper;
    private void OnMouseDown()
    {
        Debug.Log("Clic+");
        bootstrapper.IncrementPoint();
    }
}
