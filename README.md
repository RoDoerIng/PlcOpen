# PlcOpen
A Collection of tools to work with PlcOpen projects, mainly the XML project files

### Required Software
- Microsoft Visual Studio 2017
- yEd Graph Editor


## PlcOpen-XML
### Structure
The following tree structure shows how plcopen documents are structured.

```
.
+-- fileHeader.xml
+-- contentHeader.xml
+-- types
|   +-- datatypes
|       +-- datatype1.xml
|       +-- datatype2.xml
|       +-- ...
|   +-- pous
|       +-- pou1.xml
|       +-- pou2.xml
|       +-- ...
+-- instances
|   +-- configurations
|       +-- configuration1.xml
|       +-- configuration2.xml
|       +-- ...
+-- addData
|   +-- interfaces
|       +-- interface1.xml
|       +-- interface2.xml
|       +-- ...
|   +-- projectStructure
|       +-- folder1.1
|           +-- folder2.1
|               +-- ...
|               +-- object1.xml
|               +-- object2.xml
|               +-- ...
|       +-- folder1.2
|           +-- ...
|           +-- object1.xml
|           +-- object2.xml
|           +-- ...
|       +-- object1.xml
|       +-- object2.xml
|       +-- ...
```