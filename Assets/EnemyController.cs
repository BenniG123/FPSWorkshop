using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public Transform shootingTarget;
    public GameObject projectile;
    private float timer;
    private float timeMax;

    // Use this for initialization
    void Start () {
        Transform t = GameObject.Find("Player").GetComponent<Transform>();
        GetComponent<AICharacterControl>().target = t;
        shootingTarget = t;
        timer = 0f;
        timeMax = 1f / projectile.GetComponent<ProjectileController>().fireRate;
    }

    // Update is called once per frame
    void Update () {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            GameObject p = (GameObject) Instantiate(projectile, transform.position + transform.forward + transform.up, transform.rotation);
            p.GetComponent<Transform>().LookAt(shootingTarget);
            timer = timeMax;
        }
    }
}
