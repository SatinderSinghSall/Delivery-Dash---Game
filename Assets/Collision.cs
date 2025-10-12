using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch! - Collision Occured.");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Satinder McDash passed!");
    }
}
