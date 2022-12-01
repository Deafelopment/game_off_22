using UnityEngine;

public class Target : MonoBehaviour
{

    public ParticleSystem explosionEffect;
    public float health = 100f;
    KillCounter killCounterScript;

    private void Start()
    {
        killCounterScript = GameObject.Find("KCO").GetComponent<KillCounter>();
    }

    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        killCounterScript.AddKill();
    }

}
