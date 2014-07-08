using UnityEngine;
using System.Collections;

public class Engine : MonoBehaviour
{
    public bool EngineOn;
    public bool Toggle;

    public void Start()
    {
        EngineOn = true;
        gameObject.SetActive(true);
    }

    public void Stop()
    {
        EngineOn = false;
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (!EngineOn)
        {
            return;
        }

        Toggle = !Toggle;
        transform.localScale = Toggle ? new Vector3(1, 1) : new Vector3(0.5f, 0.5f);
    }
}
