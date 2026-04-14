using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float throwCooldown = 0.5f;
    private float nextThrowTime = 0f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog && can't spam space bar
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextThrowTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextThrowTime = Time.time + throwCooldown;
        }
    }
}
