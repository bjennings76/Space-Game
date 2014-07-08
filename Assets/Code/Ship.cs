using UnityEngine;

public class Ship : MonoBehaviour
{
    public float Speed = 1f;
    public float TurnSpeed = 1f;
    public Engine Engine;

    // Update is called once per frame
    private void Update()
    {
        // Moving the ship
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MovesShipY(Speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            MovesShipY(-Speed);
        }
        else
        {
            Engine.Stop();
        }

        // Turning the ship
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            TurnShip(-TurnSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            TurnShip(TurnSpeed);
        }
    }

    // This turns the ship on the Z axis
    private void TurnShip(float turnSpeed)
    {
        transform.Rotate(0, 0, turnSpeed);
    }

    // This moves the ship in the local Y direction.
    private void MovesShipY(float speed)
    {
        transform.Translate(new Vector3(0f, speed, 0f) * Time.deltaTime);
        Engine.Start();
    }
}
