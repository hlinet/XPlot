﻿#r "PresentationCore.dll"
#r "PresentationFramework.dll"
#r "System.Xaml.dll"
#r "WindowsBase.dll"

#I "../../bin/XPlot.GoogleCharts/net45"
#r "XPlot.GoogleCharts.dll"

open System.Windows
open System.Windows.Controls
open XPlot.GoogleCharts

let initWindow() =
    let wnd = Window()
    wnd.Height <- 700.
    wnd.Width <- 1000.
    wnd.Topmost <- true
    wnd.WindowStartupLocation <- WindowStartupLocation.CenterScreen 
    wnd

let showInWindow (chart:GoogleChart) =
    let wnd = initWindow()
    let browser = new WebBrowser()
    browser.NavigateToString (chart.GetHtml())
    wnd.Content <- browser
    wnd.Show()
    "Google Chart"

fsi.AddPrinter showInWindow