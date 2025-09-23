using UnityEngine;

public class TestCammer
{
    // 1. Culling Mask 选择渲染部分层级,可以指定渲染对应层级的对象

    // 2. Projection
    //      - Perspective: 透视模式
    //          - Field of view: 视口大小
    //          - FOV Axis: 视场角 轴
    //          - Physical Cammera: 物理摄像机(模拟真实摄像机)
    //      - orthographica: 正交摄像机(一般用于2D游戏制作)

    // 3. Clipping Planes: 裁剪平面距离(只有在渲染区间的物体才可以被看到)

    // 4. Depth/Priority: 渲染顺序上的深度(数字越小越先被渲染) 越先被渲染的照片越容易被覆盖
}
