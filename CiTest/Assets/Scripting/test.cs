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
            // 【違反1】メソッド名を小文字から始めている (本来は PascalCase)
            reverseGravity(); 
        }   
    }

    /// <summary>
    /// 重力を反転させる
    /// </summary>
    void reverseGravity() // ← ここを小文字にしました
    {
        // 【違反2】ローカル変数を大文字から始めている (本来は camelCase)
        Vector2 CurrentGravity = Physics2D.gravity; 
        
        Physics2D.gravity = CurrentGravity * -1;
        Debug.Log("Gravity Inverted: " + Physics2D.gravity);
    }
}