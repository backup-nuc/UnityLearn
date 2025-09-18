using UnityEngine;

public class TestGameObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
