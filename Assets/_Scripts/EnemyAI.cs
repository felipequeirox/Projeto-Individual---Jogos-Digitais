using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public AudioClip morteClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(morteClip);
            GameController.Die();
        }
    }
}