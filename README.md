# Counters-Factory

# 🔢 Counters Factory - Windows Forms Application

A C# Windows Forms application demonstrating object-oriented programming concepts including inheritance, polymorphism, interfaces, and XML serialization.

![C#](https://img.shields.io/badge/C%23-10.0-blue)
![.NET](https://img.shields.io/badge/.NET-6.0-purple)
![Platform](https://img.shields.io/badge/Platform-Windows-lightgrey)

## 📋 Overview

Counters Factory is an educational project that implements a counter management system with two types of counters:
- **StepCounter**: Increments/decrements by configurable steps
- **ModuloNCounter**: Operates with a maximum limit (modulo N)

The application demonstrates core OOP principles and includes a login system with XML-based data persistence.

## ✨ Features

### 🔐 Authentication
- Simple login form with hardcoded demo credentials
- User: `user1` | Password: `123`

### 🎯 Counter Management
- Create and manage multiple counter instances
- Two counter types with different behaviors:
  - **StepCounter**: Standard increment/decrement by steps
  - **ModuloNCounter**: Circular counter with max limit
- Counter properties:
  - Serial number
  - Current value
  - Color (enum)
  - Manufacturing date
  - Type

### 💾 Data Persistence
- XML serialization for saving counters
- Automatic loading from `data/counters.xml`
- File-based storage system

### 🎨 User Interface
- Windows Forms GUI
- Login screen
- Main counter management form
- Custom icons and styling

## 🏗️ Architecture

### Design Patterns
- **Abstract Factory Pattern**: Counter creation
- **Repository Pattern**: Data access through DataCollection
- **Singleton Pattern**: Static DataCollection management

### Class Hierarchy
```
Counter (Abstract Base Class)
├── Implements: ICountable, IPrintable
├── StepCounter
│   └── Steps property
└── ModuloNCounter
    └── MaxLimit property

Interfaces:
├── ICountable (Reset, Increment, Decrement)
└── IPrintable (GetState)

Supporting Classes:
├── Date (struct)
├── DataCollection (static manager)
└── FileManager (XML I/O)

Enums:
├── EnumColor
└── EnumCounterType
```

## 🛠 Technical Stack

**Language**: C# 10.0  
**Framework**: .NET 6.0 / .NET Framework 4.8  
**UI**: Windows Forms  
**Serialization**: XML (System.Xml.Serialization)  
**IDE**: Visual Studio 2022

## 📂 Project Structure
```
CountersFactory/
├── bus/                          # Business Logic Layer
│   ├── Counter.cs               # Abstract base class
│   ├── StepCounter.cs           # Concrete implementation
│   ├── ModuloNCounter.cs        # Concrete implementation
│   ├── ICountable.cs            # Interface for countable behavior
│   ├── IPrintable.cs            # Interface for display
│   ├── Date.cs                  # Date structure
│   ├── EnumColor.cs             # Color enumeration
│   ├── EnumCounterType.cs       # Counter type enumeration
│   ├── DataCollection.cs        # Static data manager
│   └── FileManager.cs           # XML persistence
├── user/                         # UI Layer
│   ├── LoginForm.cs             # Login screen
│   ├── LoginForm.Designer.cs    # Generated UI code
│   ├── Form1.cs                 # Main application form
│   └── Form1.Designer.cs        # Generated UI code
├── data/                         # Data storage
│   └── counters.xml             # Serialized counters
├── Properties/                   # Project properties
└── Program.cs                   # Application entry point
```

## 🎓 OOP Concepts Demonstrated

### 1️⃣ **Inheritance**
- `StepCounter` and `ModuloNCounter` inherit from `Counter`
- Base class provides common functionality
- Derived classes add specific behavior

### 2️⃣ **Polymorphism**
- **Static (Compile-time)**: Constructor overloading
- **Dynamic (Runtime)**: Method overriding (`GetState`, `Increment`, `Decrement`)

### 3️⃣ **Abstraction**
- Abstract `Counter` class with abstract methods
- Interfaces define contracts (`ICountable`, `IPrintable`)

### 4️⃣ **Encapsulation**
- Private fields with public properties
- Controlled access to counter state

### 5️⃣ **Serialization**
- XML serialization using `[Serializable]` attribute
- `XmlInclude` for derived types
- Persistent storage implementation

## 🚀 Getting Started

### Prerequisites
- Windows OS
- Visual Studio 2019 or later
- .NET Framework 4.8 or .NET 6.0+

### Installation

1. **Clone the repository**
```bash
   git clone https://github.com/yourusername/CountersFactory.git
   cd CountersFactory
```

2. **Open in Visual Studio**
   - Open `CountersFactory.sln`
   - Restore NuGet packages (if any)

3. **Build the project**
   - Press `Ctrl+Shift+B` or
   - Build → Build Solution

4. **Run the application**
   - Press `F5` or
   - Debug → Start Debugging

### Usage

1. **Login**
   - Username: `user1`
   - Password: `123`

2. **Create Counters**
   - Select counter type (StepCounter or ModuloNCounter)
   - Set properties (serial number, color, date, etc.)
   - Add to collection

3. **Manage Counters**
   - View all counters
   - Increment/Decrement values
   - Reset counters
   - Remove counters

4. **Save/Load**
   - Data automatically persists to `data/counters.xml`
   - Counters reload on application restart

## 📊 Class Diagram

See `ClassDiagram1.cd` for visual representation of the class structure.

## 🧪 Sample Counter Operations

### StepCounter Example
```csharp
StepCounter counter = new StepCounter(
    serialNumber: 1001,
    value: 0,
    color: EnumColor.Blue,
    madeDate: new Date(29, 1, 2026),
    type: EnumCounterType.StepCounter,
    steps: 5
);

counter.Increment();      // value = 1
counter.Increment(10);    // value = 11
counter.Reset();          // value = 0
```

### ModuloNCounter Example
```csharp
ModuloNCounter counter = new ModuloNCounter(
    serialNumber: 2001,
    value: 1,
    color: EnumColor.Red,
    madeDate: new Date(29, 1, 2026),
    type: EnumCounterType.ModuloNCounter,
    maxLimit: 10
);

counter.Increment();      // value = 3 (increments by 2)
counter.Increment(5);     // value = 8
counter.Reset();          // value = 1
```

## 🔧 Configuration

The XML file path is configured in `FileManager.cs`:
```csharp
private static String xmlFilePath = @"../../../data/counters.xml";
```

Adjust this path if needed for your deployment environment.

## 📝 Notes

- **Demo Credentials**: This is a learning project with hardcoded login credentials
- **Data Storage**: XML files are stored in the `data/` folder
- **Counter Limits**: ModuloN counters use modulo arithmetic
- **Serialization**: Both counter types must be decorated with `[Serializable]`

## 🎯 Learning Objectives

This project was created to demonstrate:
- ✅ Object-Oriented Programming principles
- ✅ Abstract classes and interfaces
- ✅ Polymorphism (static and dynamic)
- ✅ XML serialization/deserialization
- ✅ Windows Forms development
- ✅ Layered architecture (UI, Business Logic)
- ✅ Collection management

**Built with C# and Windows Forms** 🔢
