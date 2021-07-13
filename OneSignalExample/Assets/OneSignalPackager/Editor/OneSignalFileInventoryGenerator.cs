using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Creates the <see cref="OneSignalFileInventory"/> resource to be distributed with the SDK *.unitypackage
/// </summary>
public sealed class OneSignalFileInventoryGenerator : ScriptableObject
{
    /// <summary>
    /// Run from the internal OneSignal menu or cmdline to create a inventory resource to distribute
    /// </summary>
    [MenuItem("OneSignal/Generate File Inventory", false, 100)]
    public static void GenerateInventory()
    {
        var inventory = ScriptableObject.CreateInstance<OneSignalFileInventory>();
        inventory.DistributedPaths = inventory.CurrentPaths;

        Directory.CreateDirectory(OneSignalFileInventory.EditorResourcesPath);
        AssetDatabase.CreateAsset(inventory, OneSignalFileInventory.AssetPath);
    }
}