using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  
	public float speed = 1;

	Rigidbody2D myBody = null;



	// Use this for initialization
	void Start () {
		myBody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		//Показує силу, з якою користувач натискає на "джойстик"
		float value = Input.GetAxis("Horizontal");

		//Керування кроликом за допомогою клавіатури
		// speed (встановленна за замовчуванням швидківсть кролика)
		// value (ініціалізована вище сила давлення користувача на джойстик)

		if (Mathf.Abs(value)>0) {
			Vector2 vel = myBody.velocity;
			vel.x = speed * value;
			myBody.velocity = vel;
		}

		//Зміна напрямку кролика зі зміною напрямку руху
		// FlipX в компоненті SpriteRenderer

		SpriteRenderer sr = GetComponent<SpriteRenderer>();
		if (value>0){
			sr.flipX=false;
		} else if (value<0){
			sr.flipX=true;
		}

	}
}
