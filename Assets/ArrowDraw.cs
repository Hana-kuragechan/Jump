using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ArrowDraw : MonoBehaviour
{

    [SerializeField]
    private Image arrowImage;
    private Vector3 clickPosition;
    // Start is called before the first frame update
    void Start()
    {
        arrowImage.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // ���̉摜���o��
            arrowImage.gameObject.SetActive(true);
            arrowImage.rectTransform.sizeDelta = Vector2.zero;
            clickPosition = Input.mousePosition;    // �}�E�X�̂�����W
            // ���̉摜���h���b�O�J�n�ʒu�Ɉړ�����
            arrowImage.rectTransform.position = clickPosition;
        }   // �h���b�O�J�n�����o
        else if (Input.GetMouseButton(0))
        {
            
            Vector3 dragVector = clickPosition - Input.mousePosition;
            // �x�N�g���̒����𓾂�            
            float size = dragVector.magnitude;
            // �����x�N�g���̕����Ɍ�����
            arrowImage.rectTransform.right = dragVector;
            // �h���b�O���������񂵂������傫������
            arrowImage.rectTransform.sizeDelta = Vector2.one * size;
        }   // �h���b�O���Ă���ԏ�������
        else if (Input.GetMouseButtonUp(0))
        {
            // ���̉摜������
            arrowImage.gameObject.SetActive(false);
        }
    }
}

