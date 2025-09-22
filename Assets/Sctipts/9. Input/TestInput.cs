using UnityEngine;

public class TestInput : MonoBehaviour
{
    void Update()
    {
        // 1. 获取鼠标在屏幕的位置(游戏界面)
        // print("鼠标在屏幕的位置" + Input.mousePosition);
        // 2. 检测鼠标输入 0左键 1右键 2中键 (游戏界面)
        //  鼠标按下
        if (Input.GetMouseButtonDown(0))
        {
            print("鼠标左键按下");
        }
        //  鼠标抬起
        if (Input.GetMouseButtonUp(0))
        {
            print("鼠标左键抬起");
        }
        //  鼠标长按,按下,抬起都会进入(长按会一直进入)
        if (Input.GetMouseButton(1))
        {
            print("鼠标右键长按,按下,抬起");
        }
        //中键滚动 y = -1下  1 上 0没有滚。返回值是vector的值
        print(Input.mouseScrollDelta);
        // 3. 检测键盘输入 
        if (Input.GetKeyDown(KeyCode.W)) //W不区分大小写 Input.GetKeyDown("w"); //小写,区分大小写
        {
            print("W/w键按下");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            print("W/w键抬起");
        }
        //键盘长按,按下,抬起都会进入
        if (Input.GetKey(KeyCode.W))
        {
            print("W/w键长按");
        }
        //4. 设置默认轴输入
        //  键盘AD按下时返回-1到1之间的变换 
        print("Horizontal" + Input.GetAxis("Horizontal"));
        //  键盘SW按下时返回-1到1之间的变换
        print("Vertical" + Input.GetAxis("Vertical"));
        //  鼠标横向移动时-1到1左右
        print("Mouse X" + Input.GetAxis("Mouse X"));
        //  鼠标竖向移动时-1到1下上
        print("Mouse Y" + Input.GetAxis("Mouse Y"));
        //GetAxisRow方法和GetAxis方法相同,不过它的返回值只会是-1 0 1
    }
}
