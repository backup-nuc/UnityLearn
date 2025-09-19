using UnityEngine;

public class TestGameObject : MonoBehaviour
{

    public GameObject obj;
    void Start()
    {
        // 一. gameObject的成员变量
        // 1. 挂载的节点名称
        print(this.gameObject.name);
        this.gameObject.name = "修改名字";
        print(this.gameObject.name);
        // 2. 是否激活
        print(this.gameObject.activeSelf);
        // 3. 是否静态
        print(this.gameObject.isStatic);
        // 4. 层级
        print(this.gameObject.layer);
        // 5. 标签
        print(this.tag);
        // 6. transform
        print(this.gameObject.transform.position);

        // 二. GameObject的静态方法
        // 1. 创建自带几何体
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "创建方块";

        // 2. 查找对象相关知识
        //    - 查找单个对象 (场景中存在多个物体,无法准确找到那个物体)
        //          - 通过对象名查找(查找场景中所有的对象)
        obj = GameObject.Find("创建方块"); //无法找到失活对象
        if (obj != null)
        {
            print(obj.name);
        }
        //          - 通过tag查找
        obj = GameObject.FindWithTag("Player"); //无法找到失活对象
        // GameObject.FindGameObjectWithTag("Player");
        if (obj != null)
        {
            print(obj.name);
        }
        //    - 查找多个对象 (只能找激活的对象)
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print(objs.Length);

        // 3. 实例化对象(克隆)方法
        GameObject clone_obj = GameObject.Instantiate(this.obj);
        // 4. 删除对象方法
    }


    void Update()
    {
        
    }
}
