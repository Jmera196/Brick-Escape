using UnityEngine;

public class Brick : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Ball")) return;
        Destroy(gameObject);
    }
    
}
