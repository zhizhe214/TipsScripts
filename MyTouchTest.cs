/*
脚本名称：
脚本作者：feng.gao
建立时间：
脚本功能：判断平台是否为Android
        //在Unity开发中捕捉Android的常用事件其实很简单
公司名称：
版本号：Alpha
*/

using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using HedgehogTeam.EasyTouch;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class MyTouchTest : MonoBehaviour 
{

    public Text tex;
    private int count = 0;
    MeshRenderer mesh;
		void Start () 
		{
        EasyTouch.On_TouchStart += this.On_TouchStart;//注册单击事件
        EasyTouch.On_DoubleTap += this.On_DoubleTap;//注册双击事件
        EasyTouch.On_TouchStart2Fingers += this.On_TouchStart2Fingers;//注册两根手指事件
        mesh = GetComponent<MeshRenderer>();
	    }



    void OnDisable()
    {
        EasyTouch.On_TouchStart -= this.On_TouchStart;//注销单击事件
        EasyTouch.On_DoubleTap -= this.On_DoubleTap;//注销双击事件
        EasyTouch.On_TouchStart2Fingers -= this.On_TouchStart2Fingers;//注册两根手指事件

    }

    void On_TouchStart(Gesture g)
    {
        tex.text = (++count).ToString();
    }

    void On_DoubleTap(Gesture g)
    {
        mesh.material.color = new Color(Random.Range(0,1.0f), Random.Range(0, 1.0f), Random.Range(0, 1.0f));
    }

    void On_TouchStart2Fingers(Gesture g)
    {
        mesh.material.color = Color.green;
    }

   public  void QuitGame()
    {
        Application.Quit();
    }

    void Update()
    {
        //判断平台是否为Android
        //在Unity开发中捕捉Android的常用事件其实很简单
        if (Application.platform==RuntimePlatform.Android)
        {
            //判断当前的输入是否为Home键
            if (Input.GetKeyDown(KeyCode.Home))
            {
                Application.Quit();//退出程序
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();//退出程序
            }
        }
    }
}
