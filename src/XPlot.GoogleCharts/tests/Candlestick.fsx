﻿#I "../../../bin/XPlot.GoogleCharts/net45"
#r "XPlot.GoogleCharts.dll"

open XPlot.GoogleCharts

let chart =
    [
        "Mon", 20, 28, 38, 45
        "Tue", 31, 38, 55, 66
        "Wed", 50, 55, 77, 80
        "Thu", 77, 77, 66, 50
        "Fri", 68, 66, 22, 15        
    ]
    |> Chart.Candlestick
    |> Chart.Show
