﻿using UnityEngine;
using UnityEngine.UI;

public class catto : MonoBehaviour {
    public float speed;
    public float directionPower;
    public int point;
    public GameObject canvas;
    public Text score;
    
	// Use this for initialization
	void Start () {
        canvas.SetActive(false);
        Time.timeScale = 1;
        point = 0;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
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
            directionPower += 1.5f;
            touch.gameObject.GetComponentInParent<path>().isTouched = true;
            point++;
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
        canvas.SetActive(true);
        score.text = point.ToString();
    }
}
