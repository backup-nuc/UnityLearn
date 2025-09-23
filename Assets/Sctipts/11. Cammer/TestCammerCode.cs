using UnityEngine;

public class TestCammerCode : MonoBehaviour
{
    void Start()
    {
        // 1. Cammer静态成员
        //      - 获取摄像机
        print(Camera.main.name); // 获取场景的主摄像头(必须设置Tag为Main Cammer否则会为空)
    }
}
