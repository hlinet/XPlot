﻿#I "../../bin/XPlot.GoogleCharts/net45"
#r "XPlot.GoogleCharts.dll"
 
open XPlot.GoogleCharts
 
let sales = ["2013", 1000; "2014", 1170; "2015", 660; "2016", 1030]
let expenses = ["2013", 400; "2014", 460; "2015", 1120; "2016", 540]
 
let options =
    Options(
        title = "Company Performance",
        curveType = "function",
        legend = Legend(position = "bottom")
    )
            
let chart =
    [sales; expenses]
    |> Chart.Line
    |> Chart.WithOptions options
    |> Chart.WithLabels ["Sales"; "Expenses"]
    |> Chart.Show