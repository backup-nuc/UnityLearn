using UnityEngine;

public class TestLight : MonoBehaviour
{
    void Start()
    {
        // 1. Type 光源类型
        // Point点光源,Spot聚光灯,Area面光源(为了减少计算量使用预先计算好的光照,不会实时渲染)

        // 2. Color 光照颜色

        // 3. Mode 光源模式
        //  Realtime: 实时光源,每帧实时计算好,效果好,性能消耗大
        //  Baked: 烘焙光源,事先计算好,无法动态变化
        //  Mixed: 混合光源,预先计算+实时运算

        // 4. Intensity: 光源亮度

        // 5. Shadow Type: 阴影类型
        //  NoShadows: 关闭阴影
        // HardShadows: 生硬阴影
        // SoftShadows: 柔和阴影

        // 6. Cookie: 投影遮罩,需要配合对应的材质使用

        // 7. Draw Halo: 球形光环开关

        // 8. Flare: 耀斑
    } 
}
