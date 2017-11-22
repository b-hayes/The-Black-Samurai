using UnityEngine;
using System.Collections;

public class EnemyBehavour : MonoBehaviour {

	public float walkSpeed = 5f;
	public float patrolDistance = 10f;
	public bool startLeft = true;
	public bool stopMovingToAttack = true;
	public float health = 30f;

	private Vector3 startPosition;
	private float LeftOrRight = 1f;
	private Transform enemy;
	private Vector3 newPosition;
	private float maxDistance;

	// Use this for initialization
	void Start () {

		if (startLeft)
						LeftOrRight = -1f;

		enemy = this.gameObject.transform;
		startPosition = enemy.transform.position;
	
	}


	// Update is called once per frame
	void Update () {


		//patroling arround
		newPosition = enemy.transform.position; //the enemys current position lets pretend its currently 1000.

		maxDistance = startPosition.x + (patrolDistance * LeftOrRight); //with default settings that 1000 will now be 900

		newPosition.x = newPosition.x + (walkSpeed * LeftOrRight * Time.deltaTime); //new postion to put enemy at

		enemy.transform.position = newPosition; //now we actually move the enemy

		//now we chck if the new position is past the max distance if so change direction.
		if (LeftOrRight == -1f && newPosition.x < maxDistance) { //if we are going left and newpos.x is less than that 900

			LeftOrRight = 1f;// then change direction
			enemy.transform.localScale = new Vector3 (enemy.transform.localScale.x*-1, enemy.transform.localScale.y, enemy.transform.localScale.z);//also flip the object arround

		} else if (LeftOrRight == 1f && newPosition.x > maxDistance) { //if going right and newpos.x is greater than max

			LeftOrRight = -1f;
			enemy.transform.localScale = new Vector3 (enemy.transform.localScale.x*-1, enemy.transform.localScale.y, enemy.transform.localScale.z);

		}

	}
}
