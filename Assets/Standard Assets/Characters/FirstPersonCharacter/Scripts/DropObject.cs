using UnityEngine;
using System.Collections;

public class DropObject : MonoBehaviour
{
    public GameObject speaker1;
    public GameObject speaker2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            speaker1.transform.position = this.transform.position + this.transform.forward + new Vector3(0, 1, 0);
            speaker1.transform.rotation = new Quaternion(0, this.transform.rotation.y, 0, 1);
        }
        if (Input.GetMouseButtonDown(1))
        {
            speaker2.transform.position = this.transform.position + this.transform.forward + new Vector3(0, 1, 0);
            speaker2.transform.rotation = new Quaternion(0, this.transform.rotation.y, 0, 1);
        }
    }
}
