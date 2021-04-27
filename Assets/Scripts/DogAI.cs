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

        Vector3 targetDirection = target.transform.position - transform.position;
        float singleStep = speed * Time.deltaTime;

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        transform.rotation = Quaternion.LookRotation(newDirection);

        if (distance >= 3f)
        {
            transform.position = Vector3.MoveTowards(parentObj.transform.position, target.transform.position, speed * Time.deltaTime);
        }

    }

}