using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV_Puzzel : MonoBehaviour
{
	public GameObject TV_A, TV_B, TV_C, TV_D, TV_E, TV_F, TV_G, TV_H, TV_I;
	Vector3 TV_A_Aim = new Vector3(8.08f, -0.3f, -4.72f);
	Quaternion TV_A_Qua = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);


	// Use this for initialization
	void Start()
	{
		//LuoGan04 = GameObject.Find("04_LuoGan");
		print(TV_A.name);

	}

	// Update is called once per frame
	void Update()
	{

		print("原位置：" + TV_A.transform.localPosition);
		print("移動位置：" + TV_A_Aim);

		print("距離：" + (TV_A.transform.localPosition - TV_A_Aim).magnitude);

		if (Mathf.Sqrt((TV_A.transform.localPosition - TV_A_Aim).magnitude) < 0.5f)
		{
			TV_A.transform.localPosition = TV_A_Aim;
			TV_A.transform.localRotation = TV_A_Qua;
		}

		if (Mathf.Sqrt((TV_B.transform.localPosition - TV_A_Aim).magnitude) < 0.5f)
		{
			TV_B.transform.localPosition = TV_A_Aim;
			TV_B.transform.localRotation = TV_A_Qua;
		}

		if (Mathf.Sqrt((TV_C.transform.localPosition - TV_A_Aim).magnitude) < 0.5f)
		{
			TV_C.transform.localPosition = TV_A_Aim;
			TV_C.transform.localRotation = TV_A_Qua;
		}

		if (Mathf.Sqrt((TV_D.transform.localPosition - TV_A_Aim).magnitude) < 0.5f)
		{
			TV_D.transform.localPosition = TV_A_Aim;
			TV_D.transform.localRotation = TV_A_Qua;
		}

		if (Mathf.Sqrt((TV_E.transform.localPosition - TV_A_Aim).magnitude) < 0.5f)
		{
			TV_E.transform.localPosition = TV_A_Aim;
			TV_E.transform.localRotation = TV_A_Qua;
		}

		if (Mathf.Sqrt((TV_F.transform.localPosition - TV_A_Aim).magnitude) < 0.5f)
		{
			TV_F.transform.localPosition = TV_A_Aim;
			TV_F.transform.localRotation = TV_A_Qua;
		}

		if (Mathf.Sqrt((TV_G.transform.localPosition - TV_A_Aim).magnitude) < 0.5f)
		{
			TV_G.transform.localPosition = TV_A_Aim;
			TV_G.transform.localRotation = TV_A_Qua;
		}

		if (Mathf.Sqrt((TV_H.transform.localPosition - TV_A_Aim).magnitude) < 0.5f)
		{
			TV_H.transform.localPosition = TV_A_Aim;
			TV_H.transform.localRotation = TV_A_Qua;
		}

		if (Mathf.Sqrt((TV_I.transform.localPosition - TV_A_Aim).magnitude) < 0.5f)
		{
			TV_I.transform.localPosition = TV_A_Aim;
			TV_I.transform.localRotation = TV_A_Qua;
		}
	}
}
