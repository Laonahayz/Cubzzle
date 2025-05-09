using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koala_Puzzel : MonoBehaviour
{
	public GameObject Koala_A, Koala_B, Koala_C, Koala_D, Koala_E, Koala_F, Koala_G, Koala_H, Koala_I, Koala_J, Koala_K, Koala_L, Koala_M;
	Vector3 Koala_A_Aim = new Vector3(9.62f, -0.32f, -2.96f);
	Quaternion Koala_A_Qua = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

		print("原位置：" + Koala_A.transform.localPosition);
		print("移動位置：" + Koala_A_Aim);
		print("距離A：" + (Koala_A.transform.localPosition - Koala_A_Aim).magnitude);
		
		if (Mathf.Sqrt((Koala_A.transform.localPosition - Koala_A_Aim).magnitude) < 0.5f)
		{
			Koala_A.transform.localPosition = Koala_A_Aim;
			Koala_A.transform.localRotation = Koala_A_Qua;
		}

		if (Mathf.Sqrt((Koala_B.transform.localPosition - Koala_A_Aim).magnitude) < 0.5f)
		{
			Koala_B.transform.localPosition = Koala_A_Aim;
			Koala_B.transform.localRotation = Koala_A_Qua;
		}

		if (Mathf.Sqrt((Koala_C.transform.localPosition - Koala_A_Aim).magnitude) < 0.5f)
		{
			Koala_C.transform.localPosition = Koala_A_Aim;
			Koala_C.transform.localRotation = Koala_A_Qua;
		}

		if (Mathf.Sqrt((Koala_D.transform.localPosition - Koala_A_Aim).magnitude) < 0.5f)
		{
			Koala_D.transform.localPosition = Koala_A_Aim;
			Koala_D.transform.localRotation = Koala_A_Qua;
		}

		if (Mathf.Sqrt((Koala_E.transform.localPosition - Koala_A_Aim).magnitude) < 0.5f)
		{
			Koala_E.transform.localPosition = Koala_A_Aim;
			Koala_E.transform.localRotation = Koala_A_Qua;
		}

		if (Mathf.Sqrt((Koala_F.transform.localPosition - Koala_A_Aim).magnitude) < 0.5f)
		{
			Koala_F.transform.localPosition = Koala_A_Aim;
			Koala_F.transform.localRotation = Koala_A_Qua;
		}

		if (Mathf.Sqrt((Koala_G.transform.localPosition - Koala_A_Aim).magnitude) < 0.5f)
		{
			Koala_G.transform.localPosition = Koala_A_Aim;
			Koala_G.transform.localRotation = Koala_A_Qua;
		}

		if (Mathf.Sqrt((Koala_H.transform.localPosition - Koala_A_Aim).magnitude) < 0.5f)
		{
			Koala_H.transform.localPosition = Koala_A_Aim;
			Koala_H.transform.localRotation = Koala_A_Qua;
		}

		if (Mathf.Sqrt((Koala_I.transform.localPosition - Koala_A_Aim).magnitude) < 0.5f)
		{
			Koala_I.transform.localPosition = Koala_A_Aim;
			Koala_I.transform.localRotation = Koala_A_Qua;
		}

		if (Mathf.Sqrt((Koala_J.transform.localPosition - Koala_A_Aim).magnitude) < 0.5f)
		{
			Koala_J.transform.localPosition = Koala_A_Aim;
			Koala_J.transform.localRotation = Koala_A_Qua;
		}

		if (Mathf.Sqrt((Koala_K.transform.localPosition - Koala_A_Aim).magnitude) < 0.5f)
		{
			Koala_K.transform.localPosition = Koala_A_Aim;
			Koala_K.transform.localRotation = Koala_A_Qua;
		}

		if (Mathf.Sqrt((Koala_L.transform.localPosition - Koala_A_Aim).magnitude) < 0.5f)
		{
			Koala_L.transform.localPosition = Koala_A_Aim;
			Koala_L.transform.localRotation = Koala_A_Qua;
		}

		if (Mathf.Sqrt((Koala_M.transform.localPosition - Koala_A_Aim).magnitude) < 0.5f)
		{
			Koala_M.transform.localPosition = Koala_A_Aim;
			Koala_M.transform.localRotation = Koala_A_Qua;
		}
	}
}
