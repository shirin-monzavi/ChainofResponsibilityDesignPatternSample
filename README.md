# 🎯 Chain of Responsibility Example with C#

This project is an implementation of the **Chain of Responsibility** design pattern in C#.
It demonstrates how a request for help (like in a UI system) can be passed along a chain of objects until one of them decides to handle it.

## 🧠 What is the Flywieght Pattern?

The **Chain of Responsibility** pattern lets you:
- Decouple a request from its handler.
- Allow multiple objects a chance to handle a request.
- Build a chain of handlers where each object either handles the request or passes it along.

In this example, the "request" is **asking for help** on a UI element.

## 📦 Subsystem Components

### `HelpHandler` (base class)
- Defines the mechanism for:
  - Checking if a handler can provide help (`HasHelp`).
  - Passing the request along to a successor (`HandleHelp`).
  - Setting a new successor (`SetHandler`).
- Every participant in the chain inherits from this class.

### `Widget` (abstract UI element)
- Inherits from `HelpHandler`.
- Represents UI controls that live inside a parent (e.g., dialog, button).
- Stores a `_parent` reference.

### `Button` (leaf widget)
- Inherits from `Widget`.
- Can either show its own help or delegate to its parent (usually a `Dialog`).

### `Dialog` (container widget)
- Inherits from `Widget`.
- Can show dialog-specific help or delegate to something else (like the `Application`) using `SetHandler`.

### `Application` (root of the chain)
- Inherits directly from `HelpHandler`.
- Has no successor.
- Always provides global help topics if no one else can.
---

### 🛠️ Technologies Used
 
C#

.NET Framework 8.0

### 🤝 Contributing
 
Feel free to fork the repository, submit pull requests, or open issues for improvements and discussions.
