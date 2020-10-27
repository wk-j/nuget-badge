// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let id = argv.[0]
    let download =
        "[![NuGet Downloads](https://img.shields.io/nuget/dt/{id}.svg)](https://www.nuget.org/packages/{id})"
            .Replace("{id}", id)
    let template =
        "[![NuGet](https://img.shields.io/nuget/v/{id}.svg)](https://www.nuget.org/packages/{id})"
            .Replace("{id}", id)

    template |> printfn "%s"
    download |> printfn "%s"

    0
