using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    public float SelfSpeed;
    public float WorldSpeed;
    public Transform Sun;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, SelfSpeed * Time.deltaTime, Space.World);//沿着真实世界的Y轴转,自转速度为各自SelfSpeed参数乘以时间，实现自转效果
        transform.RotateAround(Sun.position, Vector3.up, WorldSpeed * Time.deltaTime);//沿着太阳的Y轴转,公转速度为各自WorldSpeed参数乘以时间，实现公转效果
    }
}
