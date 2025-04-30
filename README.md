![Platforms](https://img.shields.io/badge/platform-windows%20%7C%20osx%20%7C%20linux-lightgray.svg)
[![License](http://img.shields.io/:license-mit-blue.svg)](http://opensource.org/licenses/MIT)

**Inventor API:** 
[![Inventor API](https://img.shields.io/badge/Inventor%20API-2026-blue)](https://help.autodesk.com/view/INVNTOR/2026/ENU/?guid=GUID-6FD7AA08-1E43-43FC-971B-5F20E56C8846)

# ModelStateEditorApp

**ModelStateEditorApp** is a Windows Forms application written in C# (.NET 8.0) that connects to Autodesk Inventor 2026 via COM Interop and allows users to programmatically modify and manage model states in the currently active Inventor document.

## ✨ Features

- Connects to a running instance of Autodesk Inventor.
- Activates and modifies multiple model states programmatically.
- Simple UI using Windows Forms for quick access.
- Uses Autodesk Inventor's COM API via Interop (Inventor 2026).

## 📂 Project Structure

```
ModelStateEditorApp/
├── MainForm.cs          // Main application logic and UI
├── MainForm.Designer.cs // UI layout definitions
├── MarshalCore.cs       // Native COM handling utilities
├── Program.cs           // Application entry point
└── Properties/          // App resources and settings
```

## 🛠 Requirements

- Windows OS
- Autodesk Inventor (installed and licensed)
- Visual Studio 2022 or later
- .NET 8.0 SDK
- Reference to Autodesk Inventor's COM Library (Inventor 2026)

## 🚀 Getting Started

1. **Clone the Repository**

   ```bash
   git clone https://github.com/chandraRus/ModelStateEditorApp.git
   ```

2. **Open in Visual Studio**

   Open `ModelStateEditorApp.sln`.

3. **Set COM Reference**

   Right-click on project > Add Reference...

   COM > Type Libraries > Select Autodesk Inventor Object Library (Inventor 2026)

4. **Build and Run**

   Press F5 to start the application.

   Ensure Inventor is running before launching the app.

## 🧩 How It Works

- On startup, the application connects to a running Inventor instance.
- It accesses the active document and retrieves the ModelStates collection.
- The app activates a specific model state (e.g., the second one) and then puts multiple model states into edit mode.

## 🛠 Purpose

The primary purpose of **ModelStateEditorApp** is to provide a streamlined way for users to manage and modify model states within Autodesk Inventor documents programmatically. This application enables users to:

### I. Print the Current MemberEditScope (PrintEditScope())
This functionality allows users to print the current edit scope in the Immediate Window, displaying whether the scope is for the active member, all members, or multiple members.
![MemberEditScope](https://github.com/user-attachments/assets/f4184009-8dd9-4c8e-a106-f69255603faf)

### II. List Model States in Edit Mode (PrintModelStatesInEdit())
This functionality prints the names of model states currently in edit mode, allowing users to quickly identify which model states are being edited.

### III. Modify the Model States in Edit Mode (ChangeModelStatesInEdit())
This functionality enables users to dynamically update which model states are in edit mode without using the Inventor UI. It includes activating a specific model state and putting multiple model states into edit mode simultaneously.
![ChangeMemberEditScope](https://github.com/user-attachments/assets/8f2bdd88-1bee-49c8-925f-44256a2a71ae)

### 🔄 Before and After:

- **Before running:** Only Model State 1 is in edit mode.
- **After running:**
  - Model State 2 becomes active.
  - Model States 2, 3, and 4 are now in edit mode.

## ⚠️ Notes

- This app does not launch Inventor 2026; it must already be running.
- Inventor documents must be open and support model states.
- As drawing document do not have model state, trying this app with drawing document will not work.
- Intended for internal tools or automation, not end-user distribution.

# 📄 License

This sample is licensed under the terms of the [MIT License](http://opensource.org/licenses/MIT). Please see the [LICENSE](LICENSE) file for full details.


---

# ✍️ Written by

Chandra shekar G [chandra.shekar.gopal@autodesk.com](chandra.shekar.gopal@autodesk.com), [Autodesk Partner Development](http://aps.autodesk.com)

---
Please go this blog page for reference: [Managing Model States Edit Scope in Autodesk Inventor 2026 API](https://adndevblog.typepad.com/manufacturing/2025/04/managing-model-states-edit-scope-in-autodesk-inventor-2026-api.html) 
