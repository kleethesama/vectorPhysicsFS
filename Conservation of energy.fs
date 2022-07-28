module conservationOfEnergy
(* The relation used for these functions is: 0.5 * m * v^2 = m * g * h
Which is the equation for conversation of energy,
and only applies in situations where there is a conservative force like gravity,
and where the gravitational acceleration can be considered constant (Near the surface of Earth). *)

open FSharp.Data.UnitSystems.SI.UnitSymbols

let g = 9.81<m/s^2>

let getVelocityFromHeight (h : float<m>) = // Unit: m/s
  2.0 * g * h |> sqrt

// Gets the velocity from height, but with an initial velocity v0.
let withInitialVelocity (getVelocityFromHeight : float<m/s>) (v0 : float<m/s>) = // Unit: m/s
  getVelocityFromHeight * getVelocityFromHeight + v0 * v0 |> sqrt

let getHeightFromVelocity (v : float<m/s>) = // Unit: m
  v * v / (2.0 * g)

let getTimeFromHeight (h : float<m>) = // Unit: s
  // The equation used here is actually: h = 2 * g * t^2
  2.0 * h / g |> sqrt
