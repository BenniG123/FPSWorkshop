using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {

    public float speed;
    public float deathTimer;
    public float damage;
    public float fireRate;
    public GameObject explosion;

    // Use this for initialization
    void Start () {
        Rigidbody r = GetComponent<Rigidbody>();
        r.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Attributes a = collision.gameObject.GetComponent<Attributes>();
        if (a != null)
        {
            a.TakeDamage(damage);
        }

        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
