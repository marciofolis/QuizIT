﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablica : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("This will be called every frame");
        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetBool("tablica", true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("tablica", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
