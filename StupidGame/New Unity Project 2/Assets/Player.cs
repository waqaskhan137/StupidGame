using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10f;
	public Vector2 maxVelocity = new Vector2(3, 5);
	
	// Update is called once per frame
	void Update () {
		var forceX = 0f;
		var forceY = 0f;

		//if (Input.touchCount > 0) {

		

		var absVelX = Mathf.Abs (rigidbody2D.velocity.x);

		if (Input.GetKey ("right")) {

			if(absVelX < maxVelocity.x)
				forceX = speed;

			transform.localScale = new Vector3(1, 1, 1);

		} else if (Input.GetKey ("left")) {

			if(absVelX < maxVelocity.x)
				forceX = -speed;

			transform.localScale = new Vector3(-1, 1, 1);
		}

		if (Input.GetButtonDown("KeyCode.Space")) {
			if(transform.position.y <0){
			forceY = 30;
			transform.parent = null;
			}
			else {
				forceY = 0;
				transform.parent = null;

			}
		
		}

		rigidbody2D.AddForce (new Vector2 (forceX, forceY));

		
		if ((transform.position.y) > 1) {
			transform.position = new Vector2(transform.position.x , 1);	
		}
	
	}
}
//}