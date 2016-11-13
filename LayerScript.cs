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

public class LayerScript : MonoBehaviour 
{

		void Start () 
		{
       
        transform.SetAsLastSibling();
        Debug.Log(transform.GetSiblingIndex());
       // transform.SetAsFirstSibling();
	    }


		void Update () 
		{
	
	    }
}
