using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class BtnTest: MonoBehaviourPunCallbacks
{
    //panels
    // [SerializeField]
    // private GameObject testPanel;

    //Button
    // private Button enterLobbyBtn;
    // private Button enterRoomBtn;
    // private Button createRoomBtn;

    //InputFields
    // [SerializeField]
    // private InputField roomCodeInputField;

    #region basicFunction
    void Start()
    {
        // 해당 script를 가진 object 생성될 때
    }
    void Awake()
    {

    }
    void Update()
    {

    }
    #endregion

    #region EnterServerButton
    public void EnterServer()
    {
        Debug.Log("EnterServer() 호출");
        if (PhotonNetwork.IsConnected)
        {
            Debug.Log("이미 서버에 접속된 상태입니다.");
        }
        else
        {
            Debug.Log("서버에 연결 요청을 시작합니다.");
            bool result = PhotonNetwork.ConnectUsingSettings();
            if (result)
            {
                Debug.Log("서버에 연결완료");
            }
            else
            {
                Debug.Log("서버에 연결실패");
            }
        }
        // 마스터 서버 접속 -> 로비상태 - enterServerBtn 버튼을 실행 시킴
    }
    #endregion
}