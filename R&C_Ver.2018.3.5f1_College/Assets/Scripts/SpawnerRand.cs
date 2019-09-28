using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class SpawnerRand : MonoBehaviour
{
    public Transform HoverVehiclePrefab;
    public Transform spawnPoint;

  
    private void Start()
    {
        for (int i=0; i < 5; i++)
        {
            Instantiate(HoverVehiclePrefab, spawnPoint.position, spawnPoint.rotation);
            //GetComponent<animation["City_Vehicles_Left"]>.time = Random.Range(0.0, animation["City_Vehicles_Left"].length);
        }
        
    }

}
