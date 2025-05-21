using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    enum PuzzleTheme { Man, Koala, TV }
    [SerializeField] private PuzzleTheme puzzleTheme;       //主題
    public List<GameObject> puzzlePieces;                   //拼圖塊
    [SerializeField] private Vector3 targetPosition;        //目標位置
    private Quaternion targetRotation;                      //目標旋轉值
    public float PosThreshold = 0.5f;                       //吸附距離
    public float RotThreshold = 20f;                        //吸附旋轉值

    void Awake()
    {
        
        foreach (Transform child in transform)
        {
            puzzlePieces.Add(child.gameObject);
            child.localPosition = new Vector3(Random.Range(-1f, 2f), Random.Range(-1f, 2f), Random.Range(-1f, 2f));
        }
        switch (puzzleTheme)
        {
            case PuzzleTheme.Man:
                targetPosition = new Vector3(0f, 0f, 0f);
                foreach (GameObject piece in puzzlePieces)
                {
                    piece.transform.localPosition = new Vector3(Random.Range(-0.5f, 1f), Random.Range(-0.5f, 1f), Random.Range(-0.5f, 1f));
                }
                break;
            case PuzzleTheme.Koala:
                targetPosition = new Vector3(0f, 0f, 0f);
                foreach (GameObject piece in puzzlePieces)
                {
                    piece.transform.localPosition = new Vector3(Random.Range(-1f, 2f), Random.Range(-1f, 2f), Random.Range(-1f, 2f));
                }
                break;
            case PuzzleTheme.TV:
                targetPosition = new Vector3(0f, 0f, 0f);
                targetRotation = Quaternion.Euler(0f, 0f, 0f);
                foreach (GameObject piece in puzzlePieces)
                {
                    piece.transform.localPosition = new Vector3(Random.Range(0, 2f), Random.Range(0, 2f), Random.Range(0, 2f));
                    piece.transform.localRotation = Quaternion.Euler(Random.Range(0f, 40), Random.Range(0f, 30), Random.Range(0f, 40)); 
                }
                break;
        }
    }
    void Update()
    {
        
        foreach (GameObject piece in puzzlePieces)
        {
            float angleDiff = Quaternion.Angle(piece.transform.localRotation, targetRotation);
            if ((piece.transform.localPosition - targetPosition).magnitude < PosThreshold)
            {
                piece.transform.localPosition = targetPosition;              // 位置對齊
                if (angleDiff < RotThreshold)
                {
                    piece.transform.localRotation = Quaternion.identity;         // 旋轉對齊
                }
            }
        }
    }
}
