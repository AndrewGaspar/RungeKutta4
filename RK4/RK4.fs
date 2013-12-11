namespace NumericalAnalysis

module ODE =

    let rk4 x' (t0,x0) t =
        let h = t-t0
        let k1 = h * (x' (t0,x0))
        let k2 = h * (x' (t0 + h/2.0, x0 + k1/2.0))
        let k3 = h * (x' (t0 + h/2.0, x0 + k2/2.0))
        let k4 = h * (x' (t0 + h, x0 + k3))
        x0 + (k1 + 2.0 * (k2 + k3) + k4)/6.0
