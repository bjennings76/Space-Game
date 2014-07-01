using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour
{
    public float speed = 1f;

    // Use this for initialization
    private void Start() { }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) { MovesShipY(1); }
        if (Input.GetKey(KeyCode.DownArrow)) { MovesShipY(-1); }
    }

    private void MovesShipY(int direction)
    {
        var throttle = direction * speed;
        this.transform.localPosition += new Vector3(0f, throttle, 0f) * Time.deltaTime;
    }

}
