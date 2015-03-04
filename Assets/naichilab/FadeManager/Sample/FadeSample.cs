using UnityEngine;
using System.Collections;

public class FadeSample : MonoBehaviour
{

	public void FadeScene ()
	{
		FadeManager.Instance.LoadLevel ("Scene1", 2.0f);
	}
}
