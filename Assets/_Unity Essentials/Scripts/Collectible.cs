using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Collectibale : MonoBehaviour
{

    public float rotationSpeed;

    public GameObject onCollectEffect;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()


    {
        transform.Rotate(0, rotationSpeed, 0);


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player")) {


            // Destroy the collectible
            Destroy(gameObject);
            
            // instantiate the particle effect
            Destroy(Instantiate(onCollectEffect, transform.position, transform.rotation), 3f);
        }
      
       

    }
}
