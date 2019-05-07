using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(InlineScriptableObjectAttribute), true)]
public class InlineScriptableObjectAttributeDrawer : PropertyDrawer
{

    #region Style Setup

    private enum BackgroundStyles
    {
        None,
        HelpBox,
        Darken,
        Lighten
    }

    /// <summary>
    /// Whether the default editor Script field should be shown.
    /// </summary>
    private static bool SHOW_SCRIPT_FIELD = false;

    /// <summary>
    /// The spacing on the inside of the background rect.
    /// </summary>
    private static float INNER_SPACING = 6.0f;

    /// <summary>
    /// The spacing on the outside of the background rect.
    /// </summary>
    private static float OUTER_SPACING = 4.0f;

    /// <summary>
    /// The style the background uses.
    /// </summary>
    private static BackgroundStyles BACKGROUND_STYLE = BackgroundStyles.HelpBox;

    /// <summary>
    /// The colour that is used to darken the background.
    /// </summary>
    private static Color DARKEN_COLOUR = new Color(0.0f, 0.0f, 0.0f, 0.2f);

    /// <summary>
    /// The colour that is used to lighten the background.
    /// </summary>
    private static Color LIGHTEN_COLOUR = new Color(1.0f, 1.0f, 1.0f, 0.2f);

    #endregion

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        float totalHeight = 0.0f;

        totalHeight += EditorGUIUtility.singleLineHeight;

        if (property.objectReferenceValue == null)
            return totalHeight;

        if (!property.isExpanded)
            return totalHeight;

        SerializedObject targetObject = new SerializedObject(property.objectReferenceValue);


    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
