### Megabonk mod

- You should create `Directory.Build.props` in the root of the solution with the following content:
```xml
<Project>
    <PropertyGroup>
        <MEGABONK_DIR Condition="'$(MEGABONK_DIR)' == ''">X:\Your\Path\TO\Megabonk</MEGABONK_DIR>
        <MEGABONK_PROFILE Condition="'$(MEGABONK_PROFILE)' == ''">X:\Your\Path\TO\Megabonk\Profile(R2ModmanBepInEx)</MEGABONK_PROFILE>
    </PropertyGroup>
</Project>
```
