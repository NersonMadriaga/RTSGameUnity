using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour 
{
    private Camera mainCamera;
    private BuildingTypeListSO buildingTypeList;
    private BuildingTypeSO buildingType;

    private void Start()
    {
        mainCamera = Camera.main;

        buildingTypeList = Resources.Load<BuildingTypeListSO>(typeof(BuildingTypeListSO).Name);
        buildingType = buildingTypeList.list[0];
        
    }
    // Update is called once per frame
    private void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(buildingType.prefab, GetMouseWorldPosition(), Quaternion.identity);
            
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            buildingType = buildingTypeList.list[1];
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            buildingType = buildingTypeList.list[0];
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }
}
