using System;
using System.Collections;
using System.Collections.Generic;
using NavMeshPlus.Components;
using UnityEngine;


public class RotateObject : MonoBehaviour
{// Start is called before the first frame update
    private float rotationSpeed = 360f; // Швидкість повороту


    private NavMeshSurface surface;


    private void Start()
    {
        surface = GameObject.Find("NavMesh").GetComponent<NavMeshSurface>();
    }

    private void Update()
    {

    }

    private void OnMouseDown()
    {
        StartCoroutine(RotateOverTime(90f, rotationSpeed));
    }

    IEnumerator RotateOverTime(float targetAngle, float speed)
    {
        float currentAngle = 0f;

        while (currentAngle < targetAngle)
        {
            float rotationAmount = Mathf.Min(speed * Time.deltaTime, targetAngle - currentAngle);
            transform.Rotate(-Vector3.forward, rotationAmount);
            currentAngle += rotationAmount;

            yield return null; // Почекати до наступного кадру
        }
        surface.UpdateNavMesh(surface.navMeshData);
    }


}
