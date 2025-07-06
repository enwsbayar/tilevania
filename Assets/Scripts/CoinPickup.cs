using System;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;
    [SerializeField] int pointsForCoinPickup = 100;

    bool wasCollected = false;

  void OnTriggerEnter2D(Collider2D collision)
  {
        if (collision.CompareTag("Player") && !wasCollected)
        {
            wasCollected = true;
            FindAnyObjectByType<GameSession>().AddToScore(pointsForCoinPickup);
            AudioSource.PlayClipAtPoint(coinPickupSFX, transform.position);
            Destroy(gameObject);
        }
  }
}
