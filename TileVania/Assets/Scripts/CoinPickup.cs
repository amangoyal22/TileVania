using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] private AudioClip coinPickupSFX;
    [SerializeField] private int score = 100;
    private void OnTriggerEnter2D(Collider2D other)
    {
        AudioSource.PlayClipAtPoint(coinPickupSFX,Camera.main.transform.position);
        FindObjectOfType<GameSession>().addToScore(score);
        Destroy(gameObject);
    }
}
