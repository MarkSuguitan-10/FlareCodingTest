# FlareCodingTest

----------------
How to use FlareExe
---------------
1.) Open up exe from, [exe location link](https://github.com/MarkSuguitan-10/FlareCodingTest/tree/main/FlareCodingTestExe)
---------------
2.) Startup UI will contain emply grid and actions menu. 
![alt text](https://github.com/MarkSuguitan-10/FlareCodingTest/blob/main/FlareScreenshot/FlareStartup.png)
---------------
3.) a.) To set grid size press action > Double click on resize grid menu.
![alt text](https://github.com/MarkSuguitan-10/FlareCodingTest/blob/main/FlareScreenshot/FlareActionsResizeOption.png))
---------------
    b.) This will open the resize grid dialog menu. Press Cancel to exit without resizing, Press Ok to create new grid.
![alt text](https://github.com/MarkSuguitan-10/FlareCodingTest/blob/main/FlareScreenshot/FlareActionsResizeDialog.png)
---------------
4.) a.) Sample output if 5x5 grid.
![alt text](https://github.com/MarkSuguitan-10/FlareCodingTest/blob/main/FlareScreenshot/FlareDatagridview5by5.png)
---------------
    b.) Sample output if 25x25 grid.
![alt text](https://github.com/MarkSuguitan-10/FlareCodingTest/blob/main/FlareScreenshot/FlareDatagridview25by25.png)
---------------
    c.) Error message when data input is lower than 5 or bigger than 25 for both height and width.
![alt text](https://github.com/MarkSuguitan-10/FlareCodingTest/blob/main/FlareScreenshot/FlareActionsResizeDialogError.png)
5.) a.) Adding Rectangles, Open Actions Menu > Select Add Rectangle Tab
![alt text](https://github.com/MarkSuguitan-10/FlareCodingTest/blob/main/FlareScreenshot/FlareDatagridAddRectangeErrorOption.png)
---------------
    b.) Add Rectangle Dialog Appear to UI. 
    * Starting coordinate sets at which the upper left corner of the rectangle will it start (XX,YY)
        *XX is numbers from 00->24 represents the rows of the grid.
        *YY is numbers from 00->24 represents the columns of the grid.
![alt text](https://github.com/MarkSuguitan-10/FlareCodingTest/blob/main/FlareScreenshot/FlareDatagridAddRectange.png)
---------------
    c.) Error message when data input is lower than 5 or bigger than 25 for both height and width.
        * Height is height of the rectangle.
        *It shows error when set height goes outside the size of the grid.
    * Width is width of the rectangle.
        *It shows error when set width goes outside the size of the grid.
![alt text](https://github.com/MarkSuguitan-10/FlareCodingTest/blob/main/FlareScreenshot/FlareDatagridAddRectangeErrorOutOfRange.png)
