// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "RK4.fs"
open NumericalAnalysis.ODE
open System

// Define your library scripting code here

//let f = rk4 (fun (t,x) -> x + Math.Pow(Math.E, t)) (0.0, 2.0)
//
//f 0.5

let f' (t,_) = 
    let sin = Math.Sin(t)
    Math.Sqrt(1.0 - sin * sin / 4.0)

let f1 = rk4 f' (30.0*Math.PI/180.0, 0.51788193)
let f2 = rk4 f' (90.0*Math.PI/180.0, 1.46746221)

for i = 0 to 90 do 
    let rads = float(0) * Math.PI / 180.0
    printfn "%.8f\t%.8f\t%.8f" rads (f1 rads) (f2 rads)