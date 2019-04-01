using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catto : MonoBehaviour {
    public float speed;
    public float directionPower;
    public int point;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        point = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position += Vector3.right * speed * Time.deltaTime;
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            //transform.position += Vector3.up * Time.deltaTime * speed;
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * directionPower);
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.down * directionPower);
        }
    }

    private void OnTriggerEnter2D(Collider2D touch)
    {
        if (touch.gameObject.tag.Equals("Tetik"))
        {
            speed += 0.5f;
            touch.gameObject.GetComponentInParent<path>().isTouched = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Engel"))
        {
            TheEnd();
        }
    }

    public void TheEnd()
    {
        Time.timeScale = 0;
    }
}
