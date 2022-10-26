Reproduction:

0. Create a new class library `ClassLibrary1` with the following classes:  
https://github.com/TomONeill/nswag-base-class-issue/blob/main/Class1.cs

1. `nswag types2openapi /assembly:ClassLibrary1.dll /classnames:ClassLibrary1.ExtClass /output:swagger.json`
results in:  
https://github.com/TomONeill/nswag-base-class-issue/blob/main/swagger.json

2. `nswag openapi2tsclient /input:swagger.json /output:output.ts /TypeScriptVersion:4.8 /MarkOptionalProperties /HandleReferences`
results in:  
https://github.com/TomONeill/nswag-base-class-issue/blob/main/output.ts
