using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public static class NewEditorTest {

    [Test]
    public static void EditorTest()
    {
        bool test;

        if (BuildTarget.iOS == BuildTarget.Android)
            test = false;

      //  return test;
    }
}
