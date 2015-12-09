open System

open day1
open day2
open day3
open day4
open day5
open day6
open day7
open day8

[<EntryPoint>]
let main argv = 
    printfn "Day 1 part 1 -> %A" day1.final
    printfn "Day 1 part 2 -> %A" day1.above
    printfn "Day 2 part 1 -> %A" day2.order
    printfn "Day 2 part 2 -> %A" day2.ribbon
    printfn "Day 3 part 1 -> %A" day3.amount
    printfn "Day 3 part 2 -> %A" day3.total

    printfn "Day 4 processing skipped, slow code!"
//slow    printfn "Day 4 part 1 -> %A" day4.mine
//slow    printfn "Day 4 part 2 -> %A" day4.mine_more

    printfn "Day 5 part 1 -> %A" day5.nice


    printfn "Press any key to continue, any other key to quit."
    Console.ReadKey(true) |> ignore
    0 // return an integer exit code
