using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoquitoScript : MonoBehaviour
{
    public GameObject[] colors;
    public int currentLightIndex =-1;
    int cuenta = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateNextLight()
    {
        currentLightIndex++;

        if (currentLightIndex >= colors.Length)
        {
            Debug.Log(cuenta);
            currentLightIndex = 0;
            cuenta++;
            if(cuenta >= 3)
            {
                DestroyCurrentLight(colors);
            }
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);
    }

    public void ActivatePreviousLight()
    {
        currentLightIndex--;
        if (currentLightIndex < 0)
        {
            currentLightIndex = colors.Length - 1;
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);
    }

    void DeactivateAllLights()
    {
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i].SetActive(false);
        }
    }

    public void ActivateRepeating(float t)
    {
        InvokeRepeating(nameof(ActivateNextLight),0,t);
    }

    public void DestroyCurrentLight(GameObject[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if(cuenta !> 3)
            {
                Destroy(array[i]);
            }
        }
    }
}
