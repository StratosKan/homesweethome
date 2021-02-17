using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightTremble : MonoBehaviour {

    Light light;
    public bool hasRandom = false;
    public float timer=0;
    float randomTime = 0;
    float jitterTimer=0;
    float jitterRandom = 0;
    float randomEnable = 0;
    public float jitterCooldown;
    public float jitterDuration;
    // Use this for initialization
    void Start ()
    {
        light = gameObject.GetComponent<Light>();
	}

    // Update is called once per frame
    void Update()
    {
        if (jitterCooldown != 0)
        {
            timer += Time.deltaTime;
            if (!hasRandom)
            {
                randomTime = Random.Range(1, 8);
                hasRandom = true;
            }
            if (hasRandom)
            {
                if (Mathf.Round(timer) >= Mathf.Round(randomTime))
                {
                    jitterTimer += Time.deltaTime;
                    if (jitterTimer >= 0 && jitterTimer <= jitterDuration)
                    {
                        jitterRandom += Time.deltaTime;
                        if (jitterRandom >= 0.05f)
                        {
                            randomEnable = Random.Range(0, 2);
                            if (randomEnable <= 0.5f)
                            {
                                light.enabled = true;
                            }
                            else
                            {
                                light.enabled = false;
                            }
                            jitterRandom = 0;
                        }
                    }
                    else if (jitterTimer >= jitterCooldown)
                    {
                        jitterTimer = 0;
                    }
                }
            }
        }
	}
}
