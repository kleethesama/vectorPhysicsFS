module projectileMotion

open System
open FSharp.Data.UnitSystems.SI.UnitSymbols
open conservationOfEnergy

[<Measure>] type degrees

let degreesToRad (θ : float<degrees>) =
  Math.PI * θ / 180.0 / 1.0<degrees>

let flightTime (v : float<m/s>) (θ : float<degrees>) =
  2.0 * v * Math.Sin(θ |> degreesToRad) / conservationOfEnergy.g

let maxDistance (v : float<m/s>) (θ : float<degrees>) =
  2.0 * v * v * Math.Sin(θ |> degreesToRad) * Math.Cos(θ |> degreesToRad) / conservationOfEnergy.g

let getPositionX (v : float<m/s>) (θ : float<degrees>) (t : float<s>) =
  let vX = v * Math.Cos(θ |> degreesToRad)
  vX * t

let getPositionY (v : float<m/s>) (θ : float<degrees>) (t : float<s>) =
  let vY = v * Math.Sin(θ |> degreesToRad)
  (vY - conservationOfEnergy.g * t) * t
