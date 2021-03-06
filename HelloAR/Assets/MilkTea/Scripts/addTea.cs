﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class addTea : MonoBehaviour {

	public GameObject water;

	public Material allTea;
    public Material allMilk;
	public Material one_of_twoTea;
	public Material one_of_threeTea;
	public Material two_of_threeTea;
	public Material three_of_fourTea;
	public Material one_of_fourTea;
	public Material one_of_fiveTea;
	public Material two_of_fiveTea;
	public Material three_of_fiveTea;
	public Material four_of_fiveTea;
    public Slider difficulty;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
        


        if (amount.teaNum + amount.milkNum < Mathf.FloorToInt(difficulty.value))
        {
            amount.teaNum++;

 
        }
        bool debug = false;
		if (amount.teaNum != 0 && amount.milkNum == 0) {
			water.GetComponent<MeshRenderer> ().material = allTea;
            if (debug) Debug.Log ("tea:1or2or3,milk0");
		} else if (amount.teaNum == 1 && amount.milkNum == 1) {
			water.GetComponent<MeshRenderer> ().material = one_of_twoTea;
            if (debug) Debug.Log ("tea:1,milk1");
		} else if (amount.teaNum == 1 && amount.milkNum == 2) {
			water.GetComponent<MeshRenderer> ().material = one_of_threeTea;
            if (debug) Debug.Log ("tea:1,milk2");
		} else if (amount.teaNum == 2 && amount.milkNum == 1) {
			water.GetComponent<MeshRenderer> ().material = two_of_threeTea;
            if (debug) Debug.Log ("tea:2,milk1");
		} else if (amount.teaNum == 3 && amount.milkNum == 1) {
			water.GetComponent<MeshRenderer> ().material = three_of_fourTea;
            if (debug) Debug.Log ("tea:3,milk1");
		} else if (amount.teaNum == 1 && amount.milkNum == 3) {
			water.GetComponent<MeshRenderer> ().material = one_of_fourTea;
            if (debug) 	Debug.Log ("tea:1,milk3");
		} else if (amount.teaNum == 1 && amount.milkNum == 4) {
			water.GetComponent<MeshRenderer> ().material = one_of_fiveTea;
            if (debug) 	Debug.Log ("tea:1,milk4");
		} else if (amount.teaNum == 2 && amount.milkNum == 3) {
			water.GetComponent<MeshRenderer> ().material = two_of_fiveTea;
            if (debug) Debug.Log ("tea:2,milk4");
		} else if (amount.teaNum == 3 && amount.milkNum == 2) {
			water.GetComponent<MeshRenderer> ().material = three_of_fiveTea;
            if (debug) Debug.Log ("tea:3,milk4:");
		} else if (amount.teaNum == 4 && amount.milkNum == 1) {
			water.GetComponent<MeshRenderer> ().material = four_of_fiveTea;
            if (debug) Debug.Log ("tea:2,milk1");
		}


	}
}