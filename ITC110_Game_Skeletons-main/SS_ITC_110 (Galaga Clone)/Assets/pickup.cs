using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public CharacterBrain characterBrain;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"))
        {
            characterBrain.health++;
            Destroy(gameObject);
        }
    }
}
