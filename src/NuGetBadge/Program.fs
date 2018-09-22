// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let template =
        "[![NuGet](https://img.shields.io/nuget/v/{id}.svg)](https://www.nuget.org/packages/{id})"
            .Replace("{id}", argv.[0])
    template |> printfn "%s"
    0
