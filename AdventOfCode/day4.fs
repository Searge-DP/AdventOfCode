module day4


open System;
open System.Text;
open System.Security.Cryptography;

let input = "yzbqklnj";

let encode (t:string) =
    use md5 = MD5.Create()
    md5.ComputeHash(Encoding.UTF8.GetBytes(t))

let verify1 (b:byte[]) = b.[0] = 0uy && b.[1] = 0uy && b.[2] < 16uy

let numbers = seq { 0 .. Int32.MaxValue }

let find_for t v = numbers |> Seq.find (fun n -> encode (sprintf "%s%d" t n) |> v)

// day 4 part 1
let mine = find_for input verify1

let verify2 (b:byte[]) = b.[0] = 0uy && b.[1] = 0uy && b.[2] = 0uy

// day 4 part 2
let mine_more = find_for input verify2
