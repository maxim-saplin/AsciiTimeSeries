# AsciiTimeSeries
 C# class that renders a numerical collection (`double`) to a string which displayed with monospace font will be a time series chart. I.e. it builds ASCII boxes

![UI](https://github.com/maxim-saplin/AsciiTimeSeries/blob/master/AsciiTimeSeries.gif?raw=true)

# Usage
1. Cpoy-paste [AsciiTimeSeries.cs](https://raw.githubusercontent.com/maxim-saplin/AsciiTimeSeries/master/AsciiTimeSeries.cs) to your project.

2. Create it's instance, set Series propertie and render it to a string:
```
var ascii = new AsciiTimeSeries();
ascii.Series = series;
Console.WriteLine(ascii.RenderToString());
```

3. Or see the sample Console Project within this repo
