open System

let sayHello person = 
    printfn "Hello %s from the F# world" person

let isValid person = 
    String.IsNullOrWhiteSpace person |> not

let isAllowed person =
    person <> "Juan"

[<EntryPoint>]
let main argv =
    //if else
    printfn "print the first value of argv"
    let Person = 
        if argv.Length > 0 then
            argv.[0]
        else
            "Anonymous Person"
    printfn "Hello %s from the F# world \n" Person

    //iterate using regular for loop
    printfn "Iterate using for loop"        
    for i in 0..argv.Length - 1 do
        let person = argv.[i]
        printfn "Hello %s from f# program" person
    printfn "\n"
    
    //better way to itearte trough a list or array
    printfn "Better Iteration using for loop"     
    for person in argv do
        printfn "Hello %s from f# program" person
    printfn "\n"

    //f# default function to iterate

    argv
    |> Array.filter isValid
    |> Array.filter isAllowed
    |> Array.iter sayHello

    printfn "Nice to meet you"
    0