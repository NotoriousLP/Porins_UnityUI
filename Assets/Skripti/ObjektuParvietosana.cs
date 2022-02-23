﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//lietos interfeisus, lai nodrošinātu peles funkcijas
using UnityEngine.EventSystems;

public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
	
	private RectTransform transformacijasLogs;
	public Canvas kanva;
	//Use this for initialization
	void Start(){
		transformacijasLogs = GetComponent<RectTransform> ();
	}

	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Kreisais klikškis uz objekta!");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsākta objekta vilkšana!");
	}

	public void OnDrag(PointerEventData notikums){
		transformacijasLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;	
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Objekta vilkšana pārtraukta!");
	}
}
