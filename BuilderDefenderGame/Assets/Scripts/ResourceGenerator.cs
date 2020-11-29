using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour
{
    private List<BuildingTypeSO> buildingTypeList;
    private float[] timer;

    private void Awake()
    {
        buildingTypeList = GetComponent<BuildingTypeHolder>().list;
        Debug.Log(buildingTypeList + " length of building type list");
        timer = new float[buildingTypeList.Count];
    }
    private void Update()
    {

        for (int i = 0; i < timer.Length; i++)
        {
            timer[i] -= Time.deltaTime;

            if (timer[i] <= 0f)
            {
                timer[i] += buildingTypeList[i].resourceGeneratorData.timerMax;
                AddResource(buildingTypeList[i].resourceGeneratorData.resourceType, buildingTypeList[i].amount);
            }
        }
    }


    private void AddResource(ResourceTypeSO resourceType, int amount)
    {
        ResourceManager.Instance.AddResource(resourceType, amount);
    }

}