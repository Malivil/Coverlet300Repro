# Coverlet MSBuild 3.0.0 Missing Coverage Reproduction

## Running
Execute the `GenerateCoverageReport.bat` file in the `Coverlet300ReproTests` folder

## Examples
### Multi-Line Constructor
The property on the second line of the constructor shows as uncovered even though the body of the constructor is\
![Multi-Line Constructor](https://github.com/Malivil/Coverlet300Repro/blob/master/ExampleImages/MultiLineConstructor.png)

### Switch Pattern
The declaration and opening bracket of the Switch Pattern is uncovered even though both possible cases are covered\
![Switch Pattern](https://github.com/Malivil/Coverlet300Repro/blob/master/ExampleImages/SwitchPattern.png)

### ToString
The entire thing shows as uncovered even though there are no obvious branches and a test of the ToString method exists. A simple string return form of this method shows as 100% covered.\
![ToString](https://github.com/Malivil/Coverlet300Repro/blob/master/ExampleImages/ToString.png)
