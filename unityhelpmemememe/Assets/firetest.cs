using UnityEngine;
using System.Collections;

public class firetest : MonoBehaviour {

	public GameObject projectile;
	public float fireDelta = 0.5F;

	private float nextFire = 5.0F;
	//private GameObject newProjectile;
	float myTime = 5.0F;
	int hetimer_i;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		myTime += Time.deltaTime;
		//hetimer_i = (int)myTime;
		//Debug.Log (hetimer_i);
		if (Input.GetMouseButton(0) && myTime > nextFire) {
			nextFire = myTime + fireDelta;
			//newProjectile = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
			print("我被按下了");
			// create code here that animates the newProjectile        


	}
		if (Input.GetMouseButtonUp(0)){
			Debug.Log("Pressed left click.");
			//myTime += Time.deltaTime;
			//myTime = Time.deltaTime%5;
			nextFire = nextFire - myTime;
			myTime = 0.0F;
		}
}
}