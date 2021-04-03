# TitlebarZ
A simple titlebar customizer for Windows 10.  

## Notes
- This works only with Aero theme.
- This does not affect system's accent color.

## Building from source
```
git clone https://github.com/AlphaNecron/TitlebarZ.git
cd TitlebarZ.WPF
nuget restore
MSBuild.exe -property:Configuration=Release TitlebarZ.WPF.csproj
```

### Prebuilt binaries: [TitlebarZ](https://github.com/AlphaNecron/TitlebarZ/releases/latest)

### Demo
![Demo](https://raw.githubusercontent.com/AlphaNecron/TitlebarZ/master/demo.gif)
