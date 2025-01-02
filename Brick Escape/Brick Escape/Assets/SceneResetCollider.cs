using UnityEngine;

public class SceneResetCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            //Resets Level
            SceneController.instance.BasicLevel();
        }
        
    }
}
