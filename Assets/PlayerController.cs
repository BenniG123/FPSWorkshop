using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject projectile;
    private float timer;
    private float timeMax;

    // Use this for initialization
    void Start () {
        timer = 0f;
        timeMax = 1f / projectile.GetComponent<ProjectileController>().fireRate;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

		if (Input.GetAxis("Fire1") > 0 && timer <= 0f)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            timer = timeMax;
        }
	}
}
