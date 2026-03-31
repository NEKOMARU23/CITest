using UnityEngine;

/// <summary>
/// 重力を反転させるテストクラス
/// </summary>
public class InversionTest : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 【修正1】メソッド名を大文字から開始 (PascalCase)
            ReverseGravity();
        }
    }

    /// <summary>
    /// 重力を反転させる
    /// </summary>
    void ReverseGravity() // ← 修正：小文字から大文字へ
    {
        // 【修正2】ローカル変数を小文字から開始 (camelCase)
        Vector2 currentGravity = Physics2D.gravity;

        Physics2D.gravity = currentGravity * -1;
        Debug.Log("Gravity Inverted: " + Physics2D.gravity);
    }
}