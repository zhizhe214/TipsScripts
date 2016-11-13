/*
脚本名称：
脚本作者：feng.gao
建立时间：
脚本功能：协程里面嵌套协程
公司名称：
版本号：Alpha
*/

using UnityEngine;
using System.Collections;

public class startCoroutine : MonoBehaviour 
{

		void Start () 
		{
        StartCoroutine(doThing1());
	    }

    IEnumerator doThing1()
    {
        yield return StartCoroutine(doThing2());
        yield return new WaitForSeconds(2f);
        Debug.Log("doThing1");
    }

    IEnumerator doThing2()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("doThing2");
    }
}
