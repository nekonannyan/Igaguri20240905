using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera MainCamera;
    public Camera EffectCamera;
    public float transitionDuration = 5.0f;

    public Vector3 startPosition = new Vector3(0, 5, 3);
    public Vector3 endPosition = new Vector3(0, 10,10);

    public GameTimer gameTimer;

    [SerializeField] GameObject target;

    private void Start()
    {
        gameTimer.PausedTimer();
        StartCoroutine(CameraTranstion());
    }
    private IEnumerator CameraTranstion()
    {
        //演出用カメラをアクティブにする
        MainCamera.enabled = false;
        EffectCamera.enabled = true;
        EffectCamera.transform.position = startPosition;

        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            //Lerp関数で位置を補間して移動
            //EffectCamera.transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime/transitionDuration);
            EffectCamera.transform.RotateAround(target.transform.position, new Vector3(0, 1, 0), 0.2f);
            elapsedTime += Time.deltaTime;
            //次のフレームまで待機
            yield return null;
        }
        //カメラの位置を終了位置に持ってくる
        EffectCamera.transform.position = endPosition;
        //メインカメラをアクティブにする
        EffectCamera.enabled=false;
        MainCamera.enabled = true;

        //演出が終わったらタイマーを開始
        gameTimer.StartTimer();
    }
}
