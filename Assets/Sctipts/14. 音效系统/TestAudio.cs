using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAudio : MonoBehaviour
{
    // 1. 音频文件导入,常用格式wav,mp3,ogg,aiff

    // 2. 音频文件属性设置
    //  - Force To Mono: 多声道转单声道; Normalize: 强制为单声道,在混合过程中被标准化
    //  - Load in background: 在后台加载, 不阻塞主线程
    //  - Ambisonic: 立体混合声
    //  - LoadType: 加载类型    
    //      Decompress On Load: 不压缩, 内存占用高, 加载快(适合小音效)
    //      Compress in memory: 压缩, 内存占用低, 加载慢(适合大音效)
    //      Streaming: 以流形式存在,使用时解码,内存占用最小,CPU消耗高(性能换内存)
    //  - Preload Audio Data: 预加载音频, 勾选后进入场景就加载, 不勾选, 第一次使用时加载
    //  - Compression Format: 压缩方式
    //      PCM: 音频最高质量存储
    //      Vorbis: 相对PCM压缩更小,根据质量决定
    //      ADPCM: 包含噪音会被多次播放的声音, 如碰撞声
    //  - Quality: 音频质量(确定要应用压缩剪辑的压缩量,不适用PCM,ADPCM)
    //  - Sample Rate Setting: (PCM和ADPCM压缩允许自动优化或手动优化采样率)
    //      Preserve Sample Rate: 设置采样率不变(默认值)
    //      Optimize Sample Rate: 自用优化采样率
    //      Override Sample Rate: 手动覆盖采样率
}
