using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAI : MonoBehaviour
{
    public float speed;
    public GameObject parentObj;
    public GameObject target;

    float distance;
    Vector3 objPos;

    void Update()
    {
        distance = Vector3.Distance(target.transform.position, parentObj.transform.position);

        if (distance >= 5f)
        {
            transform.position = Vector3.MoveTowards(parentObj.transform.position, target.transform.position, speed * Time.deltaTime);
        }

    }

}