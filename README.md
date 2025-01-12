# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it's explicitly initialized.  Uninitialized properties can result in unexpected behavior, often leading to exceptions or incorrect calculations.

The `bug.cs` file contains code exhibiting this problem. The `bugSolution.cs` file provides a corrected version.  The key is to initialize properties within the constructor to avoid this issue.

**Problem:**
When a property isn't initialized in the constructor, its default value is used. For reference types this is `null`, and for value types it is the default value for that type (e.g., 0 for `int`). Accessing this default value directly without explicit initialization might not be what the code intends to do.

**Solution:**
The best practice is to initialize properties directly in the constructor or assign values to the properties before using them.