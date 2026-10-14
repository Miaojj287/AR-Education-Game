using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class English : MonoBehaviour
{
    public GameObject Note;

    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour vb = GetComponent<VirtualButtonBehaviour>();//从Vuforia方法中获取当前按钮状态
        vb.RegisterOnButtonPressed(Pressed);//当用户按压按键时触发按压方法
        vb.RegisterOnButtonReleased(Released);//当用户松开按键时触发松开方法

    }


    public void Pressed(VirtualButtonBehaviour obj)
    {
        Note.SetActive(true);//按压时显示模型
    }

    public void Released(VirtualButtonBehaviour obj)
    {
        Note.SetActive(false);//松开时隐藏模型
    }
}
