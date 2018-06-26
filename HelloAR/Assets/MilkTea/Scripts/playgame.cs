﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playgame : MonoBehaviour {

	public GameObject UI1;
	public GameObject target;


	// Use this for initialization
	void Awake () {
		Button button = gameObject.GetComponent<Button>() as Button;//获取Button组件
		button.onClick.AddListener(myClick);//为button的OnClick事件添加监听器，当监听到Click事件时，回调myClick函数。
	}

	// Update is called once per frame
	void Update () {

	}
	void myClick(){
		UI1.active = false;
		target.active = true;
	}
}
	
