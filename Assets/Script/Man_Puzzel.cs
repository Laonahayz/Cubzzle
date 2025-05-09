using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man_Puzzel : MonoBehaviour
{
	public GameObject Man_A, Man_B, Man_C, Man_D, Man_E, Man_F, Man_G;
	Vector3 Man_A_Aim = new Vector3(11.0f, -0.25f, 0.5309186f);
	Quaternion Man_A_Qua = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);


	// Use this for initialization
	void Start()
	{
		//LuoGan04 = GameObject.Find("04_LuoGan");
		print(Man_A.name);

	}

	// Update is called once per frame
	void Update()
	{

		print("原位置：" + Man_A.transform.localPosition);
		print("移動位置：" + Man_A_Aim);

		print("距離：" + (Man_A.transform.localPosition - Man_A_Aim).magnitude);

		if (Mathf.Sqrt((Man_A.transform.localPosition - Man_A_Aim).magnitude) < 0.5f)
		{
			Man_A.transform.localPosition = Man_A_Aim;
			Man_A.transform.localRotation = Man_A_Qua;
		}

		if (Mathf.Sqrt((Man_B.transform.localPosition - Man_A_Aim).magnitude) < 0.5f)
		{
			Man_B.transform.localPosition = Man_A_Aim;
			Man_B.transform.localRotation = Man_A_Qua;
		}

		if (Mathf.Sqrt((Man_C.transform.localPosition - Man_A_Aim).magnitude) < 0.5f)
		{
			Man_C.transform.localPosition = Man_A_Aim;
			Man_C.transform.localRotation = Man_A_Qua;
		}

		if (Mathf.Sqrt((Man_D.transform.localPosition - Man_A_Aim).magnitude) < 0.5f)
		{
			Man_D.transform.localPosition = Man_A_Aim;
			Man_D.transform.localRotation = Man_A_Qua;
		}

		if (Mathf.Sqrt((Man_E.transform.localPosition - Man_A_Aim).magnitude) < 0.5f)
		{
			Man_E.transform.localPosition = Man_A_Aim;
			Man_E.transform.localRotation = Man_A_Qua;
		}

		if (Mathf.Sqrt((Man_F.transform.localPosition - Man_A_Aim).magnitude) < 0.5f)
		{
			Man_F.transform.localPosition = Man_A_Aim;
			Man_F.transform.localRotation = Man_A_Qua;
		}

		if (Mathf.Sqrt((Man_G.transform.localPosition - Man_A_Aim).magnitude) < 0.5f)
		{
			Man_G.transform.localPosition = Man_A_Aim;
			Man_G.transform.localRotation = Man_A_Qua;
		}
	}
}
