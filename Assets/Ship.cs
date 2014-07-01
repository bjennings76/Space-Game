using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour
{
    public float Speed = 1f;

    // Use this for initialization
    private void Start() { }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) { MovesShipY(1); }
        if (Input.GetKey(KeyCode.DownArrow)) { MovesShipY(-1); }
    }

    // This moves the ship in the Y direction.
    private void MovesShipY(int direction)
    {
        var throttle = direction * Speed;
        this.transform.localPosition += new Vector3(0f, throttle, 0f) * Time.deltaTime;
    }
}
