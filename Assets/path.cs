using UnityEngine;

public class path : MonoBehaviour
{
    public bool isTouched;
    public GameObject items;
    private float countSpeed;
    private float engelHizi;

    // Use this for initialization
    void Start()
    {
        isTouched = false; countSpeed = 0;
        engelHizi = 3.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTouched)
        {
            engelHizi -= (engelHizi == 0 ? 0.1f : 0.5f);
            countSpeed += 0.5f;
            Invoke("UpdateItems", engelHizi);
            isTouched = false;
        }
    }

    void UpdateItems()
    {
        transform.position += new Vector3(30, 0, 0);
    }
}
