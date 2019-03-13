using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PrefabsBatchCreation : Editor {

	[MenuItem ("NOT_Lonely/Create Prefabs from selection")]
	public static void CreatePrefabsFromSelection(){

		Transform[] transforms = Selection.transforms;
		if (transforms.Length == 0) {
			EditorUtility.DisplayDialog ("Select Objects", "You must select at least one object in the scene first!", "Ok");
			return;
		} else {
			foreach (Transform transf in transforms) {
				PrefabUtility.CreatePrefab ("Assets/" + transf.gameObject.name + ".prefab", transf.gameObject);
			}
		}

	}
}
