using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float speed = 1.0f;//定义凤凰的速度
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(-1, 0, 0);//向鸟头所指头的方向飞
        transform.Translate(dir * speed * Time.deltaTime, Space.Self);//平行移动
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.Rotate(Vector3.up, 180, Space.World);//碰撞触发trigger，掉头折返
    }
}
