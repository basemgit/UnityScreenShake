using UnityEngine;

public class Test : MonoBehaviour
{

    private CameraShake cameraShake;

    private void Start()
    {
        cameraShake = Camera.main.GetComponent<CameraShake>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(cameraShake.Shake(1f, 0.1f));
        }
    }
}
