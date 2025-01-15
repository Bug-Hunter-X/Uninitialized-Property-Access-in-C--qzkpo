# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property of a class before it has been explicitly initialized.  This can lead to unexpected behavior, particularly when dealing with value types where default values might not always be appropriate.

The `UninitializedProperty.cs` file shows the buggy code. The `UninitializedPropertySolution.cs` file provides a corrected version, showing how to handle initialization effectively.

This scenario is particularly important to understand when properties are used within multithreaded applications or complex object hierarchies where the order of initialization might not be readily apparent.