﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MachineGun : MonoBehaviour {

    public float rayDistance = 10f;
    public GameObject Laser;
    
    private bool Shot = false;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        if (Input.GetMouseButton(0) && Shot == false)
        {
            RaycastHit hit;
            Instantiate(Laser, gameObject.transform);
            Shot = true;
            StartCoroutine(Cooldown());
            if (Physics.Raycast(ray, out hit, rayDistance))
            {
                /*Debug.Log(hit.distance);
                Debug.Log(hit.collider.gameObject.name);*/
                //hit.rigidbody.AddForce((hit.transform.position - transform.position).normalized * 10f, ForceMode.Impulse);
            }
        }
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(0.5f);
        Shot = false;
    }
}
