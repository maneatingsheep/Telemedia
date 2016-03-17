using UnityEngine;
using System.Collections;

public class CarouselItem : MonoBehaviour {

    public delegate void StartTouchCallback(GameObject target);
    public delegate void EndTouchCallback(GameObject target);

    public event StartTouchCallback OnTouchStart;
    public event EndTouchCallback OnTouchEnd;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
        OnTouchStart(gameObject);
    }

    void OnMouseUp() {
        OnTouchEnd(gameObject);
    }
    
}
