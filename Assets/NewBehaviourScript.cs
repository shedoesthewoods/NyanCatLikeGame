using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    private Transform playerTransform;

	// Use this for initialization
	void Start () {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 temp = transform.position;

        temp.x = playerTransform.position.x;
        transform.position = temp;
	}
}
