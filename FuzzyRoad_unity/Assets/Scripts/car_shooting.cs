﻿using UnityEngine;
using System.Collections;

public class car_shooting : MonoBehaviour {

	public int playerID = 1;
	public int health = 100;
	int damage = 3;

	public GameObject projectile;
	public Transform Spawnpoint;

	private const float FIRE_GUN_COOLDOWN = .3f;
	private float fireGunTimer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

			if (Input.GetButtonDown ("Fire" + playerID)) {
				GameObject clone;
				clone = (GameObject)Instantiate (projectile, Spawnpoint.position + transform.forward * 5, projectile.transform.rotation);

				clone.GetComponent<Rigidbody>().velocity = Spawnpoint.TransformDirection (Vector3.forward * 80);

				fireGunTimer = FIRE_GUN_COOLDOWN;

				print ("firing");

				//Destroy(projectile, 2);
				//Destroy(Bullet_Clone, 2);
			}
		}
	
	}

