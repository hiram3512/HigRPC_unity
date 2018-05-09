# HigRPC_unity

This project is to display how to use google's gRPC with unity.

#### How to use in unity
- Set scripting runtime version to .net 4.6
[![](https://raw.githubusercontent.com/hiramtan/HigRPC_unity/master/others/20180508160421.png)](https://raw.githubusercontent.com/hiramtan/HigRPC_unity/master/others/20180508160421.png)

- Import gRPC dll to unity project
    - Google.Protobuf.dll
    - Grpc.Core.dll
    - grpc_csharp_ext.x64.dll
    - System.Interactive.Async.dll
- Create logic to test if run correct.

#### Extention
 Add user's protocol and generate code
``` cmd
Grpc.Tools.1.11.x\tools\windows_x86\protoc.exe -I../../protos --csharp_out Greeter --grpc_out Greeter ../../protos/helloworld.proto --plugin=protoc-gen-grpc=packages/Grpc.Tools.1.11.x/tools/windows_x86/grpc_csharp_plugin.exe
```
-----
**Note: Haven't test on mobile platform**
Google gRPC's source code also alert **unity support is experimental and work-in-progress.Don't expact it to work**
[![](https://raw.githubusercontent.com/hiramtan/HigRPC_unity/master/others/20180509171233.png)](https://raw.githubusercontent.com/hiramtan/HigRPC_unity/master/others/20180509171233.png)

