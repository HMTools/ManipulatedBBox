

# ManipulatedBBox
[![NuGet](https://img.shields.io/nuget/v/HMTools.ManipulatedBBox.svg)](https://www.nuget.org/packages/HMTools.ManipulatedBBox)

## About
WPF Bounding Box for easy manipulation.

## Features
- Drag & Drop
- Resize (Corners & Edges)
- Rotate
- Show BoundingBox Size
- Set Size Ratio (eg. "0.5" -> [1:2])

## Note
***Please add an issue on this repository, for every bug fix or additional feature that you wish I'll add.</br>
And I'll try to handle it as fast as I can.***

## Getting Started
ManipulatedBBox is available on NuGet:
```
Install-Package HMTools.ManipulatedBBox
```

## Code Usage Example

    xmlns:bbox="clr-namespace:ManipulatedBBox;assembly=ManipulatedBBox"

	<Grid Background="Gray">
        <bbox:BBox VerticalAlignment="Bottom" HorizontalAlignment="Left"
               Width="200" Height="200" SizeRatio="1.5">
            <Polygon Points="10,110 60,10 110,110, 80, 150, 165, 250"
             Fill="Blue" Stretch="Fill"/>
        </bbox:BBox>
    </Grid>

## ScreenShots
### Easy Activate
![ShowBBox](https://user-images.githubusercontent.com/42064794/107525655-bab0b300-6bbf-11eb-9b8a-dd8d1888d9b9.gif)


### Drag And Drop
![DragAndDropBBox](https://user-images.githubusercontent.com/42064794/107525801-df0c8f80-6bbf-11eb-9bfe-11aac6c7877e.gif)

### Rotate
![RotateBBox](https://user-images.githubusercontent.com/42064794/107525846-eb90e800-6bbf-11eb-8a51-06e2ca61e3cc.gif)

### Resize
![CornersResizeBBox](https://user-images.githubusercontent.com/42064794/107525740-d0be7380-6bbf-11eb-9b91-6c89d77b1096.gif)
![SidesResizeBBox](https://user-images.githubusercontent.com/42064794/107525906-f9df0400-6bbf-11eb-80b7-10120fc9404c.gif)
