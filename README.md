# RxSharp

RxSharp is a .NET class library designed for reading and writing RPG Maker XP `.rxdata` files, which are serialised using Ruby's Marshal format. This library allows you to interact with RPG Maker XP's data files directly from .NET, without requiring a Ruby environment. 

## Features

- **Read and write RPG Maker XP data files**: Load and save various RPG Maker XP data types, including actors, maps, items, and more.
- **Ruby environment not required**: Work with `.rxdata` files directly within .NET.
- **Supports multiple data types**: Including `RpgSystem`, `MapInfo`, `Map`, `Actor`, `Animation`, `Armor`, `Class`, `CommonEvent`, `Enemy`, `Item`, `Script`, `Skill`, `State`, `Tileset`, `Troop`, and `Weapon`.

## Installation

You can install RxSharp via NuGet:

```bash
dotnet add package RxSharp
```
## Usage

Below are some examples demonstrating how to use the `RxData` class in RxSharp to load and save different RPG Maker XP data types.

### Loading and Saving System Data

```csharp
using RxSharp;
using RxSharp.Rpg;

class Program
{
    static void Main()
    {
        // Load the RPG System data
        RpgSystem system = RxData.LoadSystem("System.rxdata");
        
        // Save the RPG System data
        RxData.Save("System.rxdata", system);
    }
}
```

### Loading and Saving Map Information

```csharp
using RxSharp;
using RxSharp.Rpg;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Load map information
        var mapInfos = RxData.LoadMapInfos("MapInfos.rxdata");
        
        // Modify the map information as needed
        mapInfos[1].Name = "Updated Map Name";
        
        // Save the map information
        RxData.Save("MapInfos.rxdata", mapInfos);
    }
}
```

### Loading and Saving Actors

```csharp
using RxSharp;
using RxSharp.Rpg;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Load the list of actors
        List<Actor> actors = RxData.LoadActors("Actors.rxdata");
        
        // Modify actor data as needed
        actors[1].Name = "Updated Actor Name";
        
        // Save the list of actors
        RxData.Save("Actors.rxdata", actors);
    }
}
```

### Loading and Saving Maps

```csharp
using RxSharp;
using RxSharp.Rpg;

class Program
{
    static void Main()
    {
        // Load a map
        Map map = RxData.LoadMap("Map001.rxdata");
                
        // Save the map
        RxData.Save("Map001.rxdata", map);
    }
}
```

## Contributing

Contributions are welcome! Please feel free to submit a pull request or file an issue on the [GitHub repository](https://github.com/optimus-code/RxSharp).

## License

RxSharp is licensed under the MIT License. See the [LICENSE](https://github.com/optimus-code/RxSharp/blob/main/LICENSE) file for more details.

---

Thank you for using RxSharp! If you have any questions or need further assistance, feel free to open an issue on GitHub. Happy coding!