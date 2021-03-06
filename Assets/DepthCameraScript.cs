﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthCameraScript : MonoBehaviour {
	RenderTexture depthRT; 
	void Start() {
		GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
		depthRT = new RenderTexture (Screen.width, Screen.height, 24, RenderTextureFormat.Depth);
		GetComponent<Camera>().targetTexture = depthRT;
	}} 
