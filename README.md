# 🔧 Joinzy — Lightweight ID-Based Binding System for Unity

(This is a additive scene change version)

**Joinzy** is a simple and modular Unity framework that enables easy connection and access to GameObjects and components across different scenes using unique string IDs.

It’s designed for clean architecture, fast prototyping, and efficient multi-scene workflows — perfect for modular level loading and UI interaction.

---

## ✨ Features

- 🔗 **ID-Based Object Linking**  
  Register any `GameObject` or `Object` with a custom ID via `SceneLinker`

- 🧠 **Global Access System**  
  Use `JoinzIn<T>` and `JoinzInID` for clean, singleton-style access to registered objects

- 🎮 **Scene-Independent**  
  Supports multi-scene workflows using `LoadSceneMode.Additive`, with `DontDestroyOnLoad` manager

- 🎛️ **Editor Integration**  
  Includes Unity editor menu and hierarchy tools to create setup objects quickly

- 🖱️ **UI Button Utilities**  
  Built-in scripts for toggling and destroying objects via UI buttons

---

## 🛠️ Example Usage

```csharp
// Access registered global manager
var gameManager = JoinzIn<GameManager>.Instance;

// Access object from any scene by ID
var enemy = JoinzInID.Get<GameObject>("Enemy1_go");
