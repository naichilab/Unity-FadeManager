using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// シーン遷移時のフェードイン・アウトを制御するためのクラス
/// </summary>
public class FadeManager : MonoBehaviour
{

	#region Singleton

	private static FadeManager instance;

	public static FadeManager Instance {
		get {
			if (instance == null) {
				instance = (FadeManager)FindObjectOfType (typeof(FadeManager));
				
				if (instance == null) {
					Debug.LogError (typeof(FadeManager) + "is nothing");
				}
			}
			
			return instance;
		}
	}

	#endregion Singleton

	/// <summary>
	/// デバッグモード
	/// </summary>
	public bool DebugMode = true;
	/// <summary>暗転用黒テクスチャ</summary>
	private Texture2D blackTexture;
	/// <summary>フェード中の透明度</summary>
	private float fadeAlpha = 0;
	/// <summary>フェード中かどうか</summary>
	private bool isFading = false;

	public void Awake ()
	{
		if (this != Instance) {
			Destroy (this.gameObject);
			return;
		}
		
		DontDestroyOnLoad (this.gameObject);
		
		//ここで黒テクスチャ作る
		this.blackTexture = new Texture2D (32, 32, TextureFormat.RGB24, false);
		this.blackTexture.ReadPixels (new Rect (0, 0, 32, 32), 0, 0, false);
		this.blackTexture.SetPixel (0, 0, Color.white);
		this.blackTexture.Apply ();
	}

	public void OnGUI ()
	{
	
		// Fade
		if (this.isFading) {		
			//透明度を更新して黒テクスチャを描画
			GUI.color = new Color (0, 0, 0, this.fadeAlpha);
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), this.blackTexture);
		}		
		
	
		if (this.DebugMode && !this.isFading) {

			//Scene一覧を作成
			//(UnityEditor名前空間を使わないと自動取得できなかったので決めうちで作成)
			List<string> scenes = new List<string> ();
			scenes.Add ("SampleScene");
			//scenes.Add ("SomeScene1");
			//scenes.Add ("SomeScene2");


			//Sceneが一つもない
			if (scenes.Count == 0) {
				GUI.Box (new Rect (10, 10, 200, 50), "Fade Manager(Debug Mode)");
				GUI.Label (new Rect (20, 35, 180, 20), "Scene not found.");
				return;
			}


			GUI.Box (new Rect (10, 10, 300, 50 + scenes.Count * 25), "Fade Manager(Debug Mode)");
			GUI.Label (new Rect (20, 30, 280, 20), "Current Scene : " + Application.loadedLevelName);

			int i = 0;
			foreach (string sceneName in scenes) {
				if (GUI.Button (new Rect (20, 55 + i * 25, 100, 20), "Load Level")) {
					LoadLevel (sceneName, 1.0f);
				}
				GUI.Label (new Rect (125, 55 + i * 25, 1000, 20), sceneName);
				i++;
			}
		}
		
		
		
	}

	/// <summary>
	/// 画面遷移
	/// </summary>
	/// <param name='scene'>シーン名</param>
	/// <param name='interval'>暗転にかかる時間(秒)</param>
	public void LoadLevel (string scene, float interval)
	{
		StartCoroutine (TransScene (scene, interval));
	}

	/// <summary>
	/// シーン遷移用コルーチン
	/// </summary>
	/// <param name='scene'>シーン名</param>
	/// <param name='interval'>暗転にかかる時間(秒)</param>
	private IEnumerator TransScene (string scene, float interval)
	{
		//だんだん暗く
		this.isFading = true;
		float time = 0;
		while (time <= interval) {
			this.fadeAlpha = Mathf.Lerp (0f, 1f, time / interval);      
			time += Time.deltaTime;
			yield return 0;
		}
		
		//シーン切替
		Application.LoadLevel (scene);
		
		//だんだん明るく
		time = 0;
		while (time <= interval) {
			this.fadeAlpha = Mathf.Lerp (1f, 0f, time / interval);
			time += Time.deltaTime;
			yield return 0;
		}
		
		this.isFading = false;
	}
}


