using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
	public Transform velocityArrow;
	public float spawnInterval;
	public GameObject objectToSpawn;
	public Text statusText;
	
	private float timeToSpawn;
	//spawns a ball when this float reaches spawn interval
	private bool ballReady;
	//indicates wheater or not a ball is ready to be released
	private Image ImageComp;
	private GameObject spawnedBall; 
	//a reference to the current ball to be released
	
	
    // Start is called before the first frame update
    void Start()
    {
		timeToSpawn = 0.0f;
		ImageComp = GetComponent<Image>();
		
        GetComponent<Image>().fillAmount = 0.0f;

		spawnedBall=Instantiate(objectToSpawn,new Vector2(0f,17f),Quaternion.identity);
		spawnedBall.GetComponent<Rigidbody2D>().simulated = false;
		ballReady = true;
    }

    // Update is called once per frame
    void Update()
    {
		if(!ballReady)
		{
			timeToSpawn += Time.deltaTime;
			setSpawnProgress(timeToSpawn/spawnInterval);
			statusText.text = (Mathf.Round((spawnInterval - timeToSpawn)*10f)/10f).ToString();
			statusText.color = new Color(1f-1f*getSpawnProgress(),1f*getSpawnProgress(),0f,1f);
			if(getSpawnProgress() >= 1.0f)//spawn progess full, spawn a ball
			{
				
				spawnedBall=Instantiate(objectToSpawn,new Vector2(0f,17f),Quaternion.identity);
				setSpawnProgress(0.0f);
				timeToSpawn = 0.0f;

				spawnedBall.GetComponent<Rigidbody2D>().simulated = false;
				ballReady = true;
				statusText.text = "Ready";

			}
		}
		else//ball is ready, get ready to release it
		{
			if(Input.GetMouseButton(0) || Input.GetButton("Fire1"))
			{
				spawnedBall.GetComponent<Rigidbody2D>().simulated = true;
				ballReady=false;
				spawnedBall = null;
			}

		}
    }
	
	
	
	private void setSpawnProgress(float progress)
	{
		ImageComp.fillAmount = progress;
	}
	private float getSpawnProgress()//ranges from 0.0 to 1.0
	{
		return ImageComp.fillAmount;
	}
}
