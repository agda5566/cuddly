using UnityEngine;
using System.Collections;

public class timetset : MonoBehaviour {

	public GameObject projectile;
	public float fireRate = 10.5F;
	private float nextFire = 5.0F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			GameObject clone = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
		}
	}
}
