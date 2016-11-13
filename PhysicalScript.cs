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

public class PhysicalScript : MonoBehaviour 
{
        private Rigidbody rig;
		void Start () 
		{
        //给刚体添加恒定的速度或角速度，应该放在Start方法中；
        //放在Update或者FixedUpdate里是错误的，因为赋值的速度本来就是不变化的，
        //放在Update里，每一帧都会重新赋值，就好比得到自身组件一样，不可能每帧都去调用
        rig = GetComponent<Rigidbody>();
        rig.angularVelocity = Vector3.up;//
        rig.velocity = Vector3.forward;
        }
          void Update ()
        {
        //放在Update或者FixedUpdate里是错误的，
       // rig.angularVelocity = Vector3.up;

        }
}
