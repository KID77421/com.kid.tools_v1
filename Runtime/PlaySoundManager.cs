using UnityEngine;

namespace KID.Tools
{
    /// <summary>
    /// 播放音效管理器
    /// </summary>
    public class PlaySoundManager : MonoBehaviour
    {
        /// <summary>
        /// 播放音效
        /// </summary>
        /// <param name="clip">音效</param>
        private void PlaySound(AudioClip clip)
        {
            SoundManager.instance.PlaySound(clip);
        }
    }
}
