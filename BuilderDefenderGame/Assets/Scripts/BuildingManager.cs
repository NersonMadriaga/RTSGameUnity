using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour 
{
    private Camera mainCamera;

    [SerializeField]
    private Transform woodHarvester_prefab;

    private void Start()
    {
        mainCamera = Camera.main;
    }
    // Update is called once per frame
    private void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(woodHarvester_prefab, GetMouseWorldPosition(), Quaternion.identity);
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }
}
