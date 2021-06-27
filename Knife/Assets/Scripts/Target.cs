using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public float explosionLifetime = 2f;

    //.GetComponent<Rigidbody>().useGravity = false;

    public GameObject explosionEffect;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            Explode();
            SoundManagerScript.PlaySound("enemyDeath");
        }
    }

    public void Explode()
    {
        Die();
        GameObject destroing = Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(destroing, explosionLifetime);

    }

    void Die()
    {
        Destroy(gameObject);
    }
}
