/*
脚本名称：
脚本作者：feng.gao
建立时间：
脚本功能：
公司名称：
版本号：Alpha
*/

using UnityEngine;
using System.Collections;

public class MyJoyStick : MonoBehaviour 
{
    public ETCJoystick joy;
		void Start () 
		{
	
	    }


		void Update () 
		{
        //Debug.Log(joy.radiusBaseValue);
        
	    }

    public void Print()
    {
        Debug.Log("移动触发事件");

    }
}
