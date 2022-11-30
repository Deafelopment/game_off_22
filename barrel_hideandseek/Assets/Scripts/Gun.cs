using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 100f;
    public float range = 50f;
    public float fireRate = 30f;
    public float impactForce = 100f;

    public Camera fpsCam;
    public ParticleSystem muzzleflash;

    private float nextTimeToFire = 0f;

    void Update()
    {

        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }

    }

    void Shoot ()
    {
        muzzleflash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

        }
    }

}
