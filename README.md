# AsciiTimeSeries
 C# class that renders a numerical collection (`double`) to a string which (when displayed with a monospace font, e.g. in terminal) will show a time series chart. I.e. it builds a graph with ASCII boxes.

![UI](https://github.com/maxim-saplin/AsciiTimeSeries/blob/master/AsciiTimeSeries.gif?raw=true)

# Usage
1. Cpoy-paste [AsciiTimeSeries.cs](https://raw.githubusercontent.com/maxim-saplin/AsciiTimeSeries/master/AsciiTimeSeries.cs) class to your project.

2. Create `AsciiTimeSeries` instance, set `Series` property and render it to a string:
```
var ascii = new AsciiTimeSeries();
ascii.Series = series;
Console.WriteLine(ascii.RenderToString());
```

See the sample Console Project within this repo
