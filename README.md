# Unity-FadeManager
Make a Fade-In(Out) scene transition on Unity3D.

[日本語版](https://github.com/naichilab/Unity-FadeManager/blob/master/README.ja.md)

# Demo
![Demo - FadeManager](https://raw.githubusercontent.com/naichilab/Unity-FadeManager/gh-pages/fademanager-demo.gif)

# Installation
1. Download from here. -> [Download ZIP](https://github.com/naichilab/Unity-FadeManager/archive/master.zip)
2. Extract downloaded zip.
3. Import assets from *FadeManager.unitypackage* to your unity3d project.  ![Import-Package](https://raw.githubusercontent.com/naichilab/Unity-FadeManager/gh-pages/import-unitypackage.png)
4. Place the *naichilab/FadeManager/Prefabs/FadeManager* on your scene.  ![Placing-Prefab](https://raw.githubusercontent.com/naichilab/Unity-FadeManager/gh-pages/fademanager-placing.gif)

# Config
## FadeManager.fadeColor
![FadeColor-option](https://raw.githubusercontent.com/naichilab/Unity-FadeManager/gh-pages/change-fadecolor.gif)

# Usage
[FadeSample.cs](https://github.com/naichilab/Unity-FadeManager/blob/master/Assets/naichilab/FadeManager/Sample/FadeSample.cs)

### FadeManager.Instance.LoadLevel (string sceneName, float timeToFade);
*Ex. FadeManager.Instance.LoadLevel ("Scene1", 2.0f);*

Please use instead of Application.LoadLevel.

# Licence

[MIT](https://github.com/naichilab/Unity-FadeManager/blob/master/LICENSE)

## Author
[@naichilab](https://github.com/naichilab)
