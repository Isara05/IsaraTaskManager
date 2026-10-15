# IsaraTaskManager ✅

**C# · Windows Forms · .NET · WiX Toolset · WinGet**

A Windows desktop task-management application developed for **SWE40006 — Software Deployment and Evolution** at Swinburne University of Technology.

## Overview
IsaraTaskManager provides a desktop interface for organising tasks and demonstrates the packaging and distribution of Windows software.

## Features
- Create and manage tasks
- Track task names, due dates, priorities, and statuses
- View tasks in a table-based interface
- Export task data in **CSV** and **JSON** formats

## Technology stack
| Component | Technology |
| --- | --- |
| Programming language | C# |
| Desktop interface | Windows Forms |
| Export libraries | CsvHelper, Newtonsoft.Json |
| Windows installer | WiX Toolset v3 / MSI |
| Package distribution | Windows Package Manager (WinGet) manifest submission |

## Deployment experience
The project included preparing an MSI installer, verifying installation and uninstallation, creating a versioned GitHub release, and submitting a WinGet package manifest for review.

> A WinGet pull request or manifest submission does not mean that the package has been accepted into the public catalogue.

## Getting started
This is a **Windows desktop application**.

1. Clone the repository:
   ```bash
   git clone https://github.com/Isara05/IsaraTaskManager.git
   ```
2. Open the available project or solution file in a compatible Visual Studio installation.
3. Restore NuGet packages and build the application.
4. Alternatively, check [GitHub Releases](https://github.com/Isara05/IsaraTaskManager/releases) for a packaged installer, if available.

## Skills demonstrated
Desktop software development · Windows packaging · Dependency management · Release management · Installation testing

---

**Project type:** Individual university software deployment project.

[← Back to my GitHub profile](https://github.com/Isara05)
