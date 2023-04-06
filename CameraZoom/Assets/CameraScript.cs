using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Camera cam;

    private float targetZoom;
    private float zoomFactor = 3f;
    [SerializeField]private float zoomLerpSpeed = 10f;
    [SerializeField]private float minZoom = 2f;
    [SerializeField]private float maxZoom = 20f;
    private float currentZoom;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        targetZoom = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        currentZoom = -Input.GetAxis("Mouse ScrollWheel");

        if (Input.GetKey(KeyCode.UpArrow)) {
            currentZoom += 0.1f;
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            currentZoom -= 0.1f;
        }

        targetZoom -= currentZoom * zoomFactor;
        targetZoom = Mathf.Clamp(targetZoom, minZoom, maxZoom);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime * zoomLerpSpeed);
    }
}
