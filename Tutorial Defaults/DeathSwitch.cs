using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Unity.InteractiveTutorials;

public class DeathSwitch : MonoBehaviour
{
    public float delayInSeconds;
    public Collider playerCollider;
    public UnityEvent PlayerDie;

    void OnTriggerEnter(Collider collider)
    {
        if (collider == playerCollider)
        {
            //StopAllCoroutines();
            PlayerDie.Invoke();
        }
    }
}
