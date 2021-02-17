using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class animationWake : MonoBehaviour {
    public Animator anim;
    float timer = 0;
    public GameObject obj;
    private void Awake()
    {
        anim.SetTrigger("onAwake");
        obj.GetComponent<FirstPersonController>().enabled=false;
    }
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;
        if (timer >= 5f)
        {
            anim.enabled = false;
            obj.GetComponent<FirstPersonController>().enabled = true;
        }
	}
}
