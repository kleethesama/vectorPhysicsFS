module projectileMotion

open System
open FSharp.Data.UnitSystems.SI.UnitSymbols
open vectors

let flightTime (vec1 : vector2D<'u>) (a : vector2D<'a>) (θ : float) =
  let v = vec1 |> magnitudeOfVector2D
  2.0 * v * Math.Sin(θ) / a.y

let maxDistance (vec1 : vector2D<'u>) (a : vector2D<'a>) (θ : float) =
  let D = vec1 |> magnitudeOfVector2D
  2.0 * D * D * Math.Sin(θ) * Math.Cos(θ) / a.y

let getPositionX (vec1 : vector2D<'u>) (θ : float) (t : float<'a>) =
  let v = vec1 |> magnitudeOfVector2D
  v * Math.Cos(θ) * t

let getPositionY (vec1 : vector2D<'u>) (a : vector2D<'a>) (θ : float) (t : float<'a>) =
  let v = vec1 |> magnitudeOfVector2D
  (v * Math.Sin(θ) - a.y * t) * t
