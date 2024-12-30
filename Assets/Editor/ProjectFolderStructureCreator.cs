using UnityEditor;
using UnityEngine;
using System.IO;

public class ProjectFolderStructureCreator : EditorWindow
{
    private static string projectName = "Project Name";
    private Vector2 scrollPosition;
    private FolderNode rootFolder;
    private string selectedFolderPath = "No folder selected";

    [MenuItem("Tools/Project Folder Creator")]
    public static void ShowWindow()
    {
        GetWindow<ProjectFolderStructureCreator>("Project Folder Creator");
    }

    private void OnEnable()
    {
        projectName = $"Project Name";
        selectedFolderPath = $"No folder selected";
        RefreshFolderStructure();
    }

    private void OnGUI()
    {
        GUILayout.Label("Project Name:");
        projectName = GUILayout.TextField(projectName);

        if (GUILayout.Button("Create Project Folder", GUILayout.Width(200), GUILayout.Height(20)))
        {
            CreateProjectFolders();
            //Close();
        }

        GUILayout.Space(30);


        // Refresh Button
        if (GUILayout.Button("Refresh Folder Structure", GUILayout.Width(200), GUILayout.Height(20)))
        {
            RefreshFolderStructure();
        }


        // Folder Structure
        if (rootFolder == null)
        {
            EditorGUILayout.LabelField("No folder structure available. Refresh to load.");
            return;
        }

        scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);
        DrawFolder(rootFolder);

        GUILayout.Space(30);

        // Display Selected Folder Path
        EditorGUILayout.LabelField("Selected Folder Path:");
        EditorGUILayout.TextField(selectedFolderPath);

        // For Creating Folders
        if (GUILayout.Button("Create Basic Structure", GUILayout.Width(200), GUILayout.Height(20)))
        {
            CreateBasicFolderStructure();
            //Close();
        }

        EditorGUILayout.EndScrollView();
    }

    private static void CreateProjectFolders()
    {
        if(string.IsNullOrEmpty(projectName) || projectName == "Project Name"){
            Debug.LogError($"selectedFolderPath should not be empty");
            return;
        }

        string[] folders = {
            "00_Common", // Common Folder
            "01_Splash", // Splash Folder
            "02_Lobby", // Lobby Folder
        };
        
        // Create the root folder if it doesn't exist

        string folderPath = Path.Combine("Assets", projectName);
        if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

        // Create Folders
        foreach (string folder in folders)
        {
            string folder_path = Path.Combine(folderPath, folder);
            if (!Directory.Exists(folder_path))
            {
                Directory.CreateDirectory($"{folderPath}/{folder}");
                Debug.Log($"Created Folder: {folder_path}");
            }
            else
            {
                Debug.LogWarning($"Folder already exists: {folder_path}");
            }
        }
        
        AssetDatabase.Refresh();
    }

    private void CreateBasicFolderStructure(){

        string folderPath = $""+selectedFolderPath; //Path.Combine("Assets", projectName);

        if(string.IsNullOrEmpty(folderPath) || folderPath == "No folder selected"){
            Debug.LogError($"selectedFolderPath should not be empty");
            return;
        }

        string[] basicFolders = {
            "Animations",
            "Audios",
            "Fonts",
            "Materials",
            "Prefabs",
            "Scripts",
            "ScriptableObjects",
            "Shaders",
            "Textures",
            "Scenes",
            "Editor"
        };

        foreach (string folder in basicFolders)
        {
            string folder_path = Path.Combine(folderPath, folder);
            if (!Directory.Exists(folder_path))
            {
                Directory.CreateDirectory($"{folderPath}/{folder}");
                Debug.Log($"Created Folder: {folder_path}");
            }
            else
            {
                Debug.LogWarning($"Folder already exists: {folder_path}");
            }
        }

        AssetDatabase.Refresh();
    }

    private void DrawFolder(FolderNode folder)
    {
        // Create foldout for the current folder
        folder.IsExpanded = EditorGUILayout.Foldout(folder.IsExpanded, folder.Name, true);

        if (folder.IsExpanded)
        {
            EditorGUI.indentLevel++;

            // Draw the folder name as a selectable label
            if (GUILayout.Button(folder.Name, GUILayout.ExpandWidth(false)))
            {
                selectedFolderPath = folder.Path; // Update selected folder path
            }

            // Draw subfolders recursively
            foreach (var subfolder in folder.Subfolders)
            {
                DrawFolder(subfolder);
            }

            EditorGUI.indentLevel--;
        }
    }

    private void RefreshFolderStructure()
    {
        string projectPath = Application.dataPath; // Start from Assets folder
        rootFolder = BuildFolderNode(projectPath);
        ExpandAllFolders(rootFolder);
    }

    private void ExpandAllFolders(FolderNode folder)
    {
        if (folder == null) return;

        folder.IsExpanded = true;

        FolderNode _subFolder = folder.Subfolders.Find(x => x.Name == "Assets");
        if(_subFolder != null &&_subFolder.Name == "Assets"){
            ExpandAllFolders(_subFolder); // Recursively expand subfolders
        }    
    }

    private FolderNode BuildFolderNode(string path)
    {
        FolderNode folderNode = new FolderNode
        {
            Name = Path.GetFileName(path),
            Path = path,
            IsExpanded = false,
            Subfolders = new System.Collections.Generic.List<FolderNode>()
        };

        string[] directories = Directory.GetDirectories(path);
        foreach (string directory in directories)
        {
            folderNode.Subfolders.Add(BuildFolderNode(directory));
        }

        return folderNode;
    }

    private class FolderNode
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public bool IsExpanded { get; set; }
        public System.Collections.Generic.List<FolderNode> Subfolders { get; set; }
    }
}

