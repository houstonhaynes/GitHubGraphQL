#r "nuget: FSharp.Data.GraphQL.Client, 1.0.7"

#if INTERACTIVE
#load @"./SnowflaqeClient/GitHubGQL.GraphqlClient.fs"
#endif

open GitHubGQL
open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

let query = getRepoCountForDateRange.query



[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message
    0 // return an integer exit code