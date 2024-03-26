using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
       transform.Translate(Vector3.forward * speed * Time.deltaTime,Space.World);
    }
}
