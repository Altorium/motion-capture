using UnityEngine;

public class UnityChanHeadLookAtCamera : MonoBehaviour
{
    public Animator animator;
    public Transform cameraTransform;

    void LateUpdate()
    {
        if (animator == null || cameraTransform == null) return;

        // ユニティちゃんの「頭」のボーンを取得
        Transform head = animator.GetBoneTransform(HumanBodyBones.Head);
        if (head == null) return;

        // カメラの方向を向かせる
        Vector3 targetPosition = cameraTransform.position;
        Vector3 direction = targetPosition - head.position;

        // 垂直方向の回転を制限したい場合は以下の行を有効化
        // direction.y = 0f;

        if (direction != Vector3.zero)
        {
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            head.rotation = Quaternion.Slerp(head.rotation, lookRotation, Time.deltaTime * 5f);
        }
    }
}