using UnityEngine;

public class FollowAvatarHead : MonoBehaviour
{
    public Transform avatarHead; // アバターの頭部のTransform

    void Update()
    {
        if (avatarHead != null)
        {
            transform.position = avatarHead.position;
            transform.rotation = avatarHead.rotation;
        }
    }
}