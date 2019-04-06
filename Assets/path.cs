using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour {
    public bool isTouched;
    public GameObject items;

	// Use this for initialization
	void Start () {
        isTouched = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isTouched)
        {
            //time değişkeni hıza göre değişkenlik göstermeli
            //float sp = GetComponentInParent<Rigidbody2D>().gameObject.GetComponent<catto>().GetSpeed;
            //float sp = items.GetComponentInParent<Rigidbody2D>().gameObject.GetComponent<catto>().GetSpeed;
            Invoke("UpdateItems", 3f);
            isTouched = false;
        }
	}

    void UpdateItems()
    {
        transform.position += new Vector3(30, 0, 0);
    }
}
