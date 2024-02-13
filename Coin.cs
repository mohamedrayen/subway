using UnityEngine;

public class Coin : MonoBehaviour
{
    public int scoreValue = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Increase score
            GameManager.instance.IncreaseScore(scoreValue);
            
            // Destroy coin
            Destroy(gameObject);
        }
    }
}
