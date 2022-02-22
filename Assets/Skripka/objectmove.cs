using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystem;


	public class ObjectuParvietosana : monoBehavior, IPointerDownHandler, IBeginDragHolder, IDragHandler, IEndDragHandler{
	private RectTransform transformacijasLogs  {
		public Canvas kanvas;
	}

	// Use this for initialization
	void start(){
		transformacijasLogs = getComponent<RectTransform> ();
	}
	public void OnPointerDown(pointerEventData notikums){
		Debug.Log ("kreisais uz objekta");
	}
	public void OnBeginDrag(pointerEventData notikums){
		Debug.Log ("uz objekta vilksanu");
	}
	public void OnDrag(pointerEventData notikums){
		TransformacijasLogs.anchoredPosition += notikums.delta / kanva.scaleFaktor;
	}
	public void OnEndDrag(pointerEventData notikums){
		Debug.Log ("obj vilksana end");
	}
}
