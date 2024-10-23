using GameDevWithMarco.ObserverPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco
{
    public class KnightView : MonoBehaviour
    {
        [SerializeField] GameEvent playerSpottedEvent;
        bool hasPlayerBeenSpotted = false;
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                Debug.Log("Player Spotted");
                playerSpottedEvent.Raise();
                hasPlayerBeenSpotted = true;
            }
        }
    }
}
