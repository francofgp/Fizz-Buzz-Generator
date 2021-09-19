# FizzBuzz Generator

![Imgur](https://i.imgur.com/PbqfDba.png)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<div align="center">
  
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Licence](https://img.shields.io/github/license/Ileriayo/markdown-badges?style=for-the-badge)
  
</div>
FizzBuzz Generator is a console program made in C# where you can specified the number (for example from 1 to 100) to resolve the FizzBuzz problem.

## [Execute in your editor](#Execute-in-your-editor)

---

Using the [.NET CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet) to run the project.

```bash
dotnet run
```

and if you want to make your own .exe single file, you will need:

```bash
dotnet publish -r win-x64 /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=false /p:SelfContained=false --output "C:\Users\PC\Desktop"
```

That will generate a .exe file, in the "C:\Users\PC\Desktop" directory.

## [Usage](#Usage)

---

To use the program just execute the .exe file

![Alt](https://i.imgur.com/mlmsfIo.gif "Optional title")

Your can also, use the following command to run the program in every platform:

```bash
dotnet run
```

### [OS](#OS)

---

The program was tested only in Windows 10, if you want to try on another Windows or Operative System, let me know.
Technically I used .NET CORE 5, so the program run in every platform.

Thanks.

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

### [Acknowledgements](#Acknowledgements)

---

-   [Spectre.Console](https://github.com/spectreconsole/spectre.console) for allow me to create beautiful console applications.
-   [Figgle](https://github.com/drewnoakes/figgle) for the ASCII banner generation for .NET.

### [License](#license)

Closures is provided under the [MIT License](https://github.com/vhesener/Closures/blob/master/LICENSE).

```text
MIT License

Copyright (c) 2021 Pértile Franco Giuliano

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

[MIT](https://choosealicense.com/licenses/mit/)
