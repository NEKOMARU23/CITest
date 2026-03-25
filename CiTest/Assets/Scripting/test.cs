using UnityEngine;

public class InversionTest : MonoBehaviour
{
    void Update()
    {
        // スペースキーを押すと重力を反転させる（予定）
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ReverseGravity(); // ← あえてセミコロンを抜いています！
        
    }

    void ReverseGravity()
    {
        Physics2D.gravity *= -1;
        Debug.Log("Gravity Inverted: " + Physics2D.gravity);
    }
}