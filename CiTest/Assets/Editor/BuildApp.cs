using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class BuildApp
{
    public static void Build()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        // ここでビルドに含めるシーンを指定します
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" }; 
        buildPlayerOptions.locationPathName = "Builds/App/CiTest.exe";
        buildPlayerOptions.target = BuildTarget.StandaloneWindows64;
        buildPlayerOptions.options = BuildOptions.None;

        Debug.Log("ビルドを開始します...");
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("ビルド成功: " + summary.totalSize + " bytes");
        }
        else
        {
            Debug.Log("ビルド失敗");
        }
    }
}