// Write functions for working with shapes in standard Planar coordinate system.

// Points are represented by coordinates
// Lines are represented by two points, marking their beginning and ending 
//You will be given three line segments. 
//Calculate their length. Check if the line segments can form a triangle.

// The input will consist of an array containing twelve values
// Line 1, Point 1 X
// Line 1, Point 1 Y
// Line 1, Point 2 X
// Line 1, Point 2 Y
// Line 2, Point 1 X
// ...

// The output should be consisted of four lines
//  - Three lines showing the length of each line segment - 2 digits of precision
// = Fourth line should be one of:
//     Triangle can be formed
//     Triangle can't be formed

function planarCoordinates(args){
    let lines = args.length,
        linesArray = [],
        a = 0;

   for (let i = 0; i < lines - 3; i += 4) {
            linesArray.push({
                x1: +args[i],
                y1: +args[i + 1],
                x2: +args[i + 2],
                y2: +args[i + 3],
            });
    }

    let sumLength = [];
    for (let i = 0; i < linesArray.length; i += 1) {
        let a = Math.abs(linesArray[i].x1 - linesArray[i].x2);
        let b = Math.abs(linesArray[i].y1 - linesArray[i].y2);
        sumLength[i] = Math.sqrt(a * a + b * b);
        console.log(sumLength[i].toFixed(2));

    }
    if (isTriangle()) {
        console.log('Triangle can be built')
    } else {
        console.log('Triangle can not be built');
    }

    function isTriangle() {
        return (sumLength[0] + sumLength[1] > sumLength[2] && sumLength[1] + sumLength[2] > sumLength[0] && sumLength[0] + sumLength[2] > sumLength[1]);
    }

}

planarCoordinates(['5', '6', '7', '8',
                   '1', '2', '3', '4',
                   '9', '10', '11', '12']);

/*
planarCoordinates(['7', '7', '2', '2',
                    '5', '6', '2', '2',
                    '95', '-14.5', '0', '-0.123']);
*/
