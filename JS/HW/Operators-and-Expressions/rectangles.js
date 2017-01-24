//Implement a javascript function that takes an argument array as a parameter and 
//calculates rectangle’s area and perimeter by given width and height. 
//The width and height will both be passed in the argument array.

function solve(args){
    let width = +args[0];
    let height = +args[1];

    let perimeter = 2*(width + height);
    let area = width * height;

    console.log(area.toFixed(2) + " " + perimeter.toFixed(2));
}

solve(['2.5', '3'] );
solve(['5', '5'] );
solve(['3', '4'] );