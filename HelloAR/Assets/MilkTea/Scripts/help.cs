﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class help : MonoBehaviour {

	public GameObject Text;


	// Use this for initialization
	void Awake () {
		Button button = gameObject.GetComponent<Button>() as Button;//获取Button组件
		button.onClick.AddListener(myClick);//为button的OnClick事件添加监听器，当监听到Click事件时，回调myClick函数。
	}

	// Update is called once per frame
	void Update () {

	}
	void myClick(){
		Text.GetComponent<Text> ().text = "Help: By tapping at certain buttons on the screen, you should add accurate amount of tea or milk into the cup, as well as one material, including pearls, nata and cover, so that you can increase your score. And you can also choose the levels for the game through tapping at the scroller. And if you want to quit, just tap at the right corner exit button. Hope you enjoy the game.";
	}
}