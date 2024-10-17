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
        //���o�p�J�������A�N�e�B�u�ɂ���
        MainCamera.enabled = false;
        EffectCamera.enabled = true;
        EffectCamera.transform.position = startPosition;

        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            //Lerp�֐��ňʒu���Ԃ��Ĉړ�
            //EffectCamera.transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime/transitionDuration);
            EffectCamera.transform.RotateAround(target.transform.position, new Vector3(0, 1, 0), 0.2f);
            elapsedTime += Time.deltaTime;
            //���̃t���[���܂őҋ@
            yield return null;
        }
        //�J�����̈ʒu���I���ʒu�Ɏ����Ă���
        EffectCamera.transform.position = endPosition;
        //���C���J�������A�N�e�B�u�ɂ���
        EffectCamera.enabled=false;
        MainCamera.enabled = true;

        //���o���I�������^�C�}�[���J�n
        gameTimer.StartTimer();
    }
}
