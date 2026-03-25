using UnityEngine;

/// <summary>
/// 重力を反転させるテストクラス
/// </summary>
public class InversionTest : MonoBehaviour
{

    // Start is called before the first frame update
    void Update()
    {
        // スペースキーを押すと重力を反転させる（予定）
        if (Input.GetKeyDown(KeyCode.Space)
        {
            ReverseGravity();// ← あえてセミコロンを抜いています！
        }   
    }

    /// <summary>
    /// 重力を反転させ
    /// </summary>
    void ReverseGravity()
    {
        Physics2D.gravity *= -1;
        Debug.Log("Gravity Inverted: " + Physics2D.gravity);
    }

}