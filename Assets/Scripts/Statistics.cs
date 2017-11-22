using UnityEngine;
using System.Collections;

public class Statistics : MonoBehaviour {

	public bool showStatistics = true;

	public Transform targetObject;
	private float maxHeightReached = 0f;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		if (targetObject.position.y > maxHeightReached){
			//report maximum height reached.
			maxHeightReached = targetObject.position.y;
			Debug.Log("Max Height Reached : " + maxHeightReached);
		}
	
	}
}
