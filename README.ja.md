# Unity-FadeManager
Unity3Dにてフェードイン（アウト）を利用したシーン間遷移を行います。

[README.md | English](https://github.com/naichilab/Unity-FadeManager/blob/master/README.md)

# デモ
![デモ](https://raw.githubusercontent.com/naichilab/Unity-FadeManager/gh-pages/fademanager-demo.gif)

# インストール
1. ダウンロード -> [Download ZIP](https://github.com/naichilab/Unity-FadeManager/archive/master.zip)
2. ダウンロードしたZIPファイルを解凍.
3. *FadeManager.unitypackage* をUnity3Dプロジェクトにインポート  
![Import-Package](https://raw.githubusercontent.com/naichilab/Unity-FadeManager/gh-pages/import-unitypackage.png)
4. *naichilab/FadeManager/Prefabs/FadeManager* をシーンに配置  ![Placing-Prefab](https://raw.githubusercontent.com/naichilab/Unity-FadeManager/gh-pages/fademanager-placing.gif)

# 設定
## FadeManager.fadeColor
![色設定](https://raw.githubusercontent.com/naichilab/Unity-FadeManager/gh-pages/change-fadecolor.gif)

# 使い方
[FadeSample.cs](https://github.com/naichilab/Unity-FadeManager/blob/master/Assets/naichilab/FadeManager/Sample/FadeSample.cs)

### FadeManager.Instance.LoadLevel (string sceneName, float timeToFade);
*Ex. FadeManager.Instance.LoadLevel ("Scene1", 2.0f);*

*Application.LoadLevel* の代わりに呼び出してください。

# ライセンス

[MIT](https://github.com/naichilab/Unity-FadeManager/blob/master/LICENSE)

## 作者
[@naichilab](https://github.com/naichilab)
