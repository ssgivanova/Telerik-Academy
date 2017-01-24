function solve(args){
    var x = +args[0];
    var y = +args[1];
    var rect = false;
    var circ = false;

    var center_x = 1, center_y = 1, radius = 1.5;
    var width = 6, height = 2;

    var a_x = -1, a_y = 1, 
        b_x = a_x + width, b_y = a_y,
        c_x = b_x, c_y = b_y - height,
        d_x = a_x, d_y = a_y - height;

    var distance = Math.sqrt((x - center_x)*(x - center_x)+(y - center_y)*(y - center_y));
    if(distance <= radius)
    {
        circ = true;
    }else{
        circ = false;
    }

    if ((x >= a_x) && (x <= b_x) && (y <= a_y) && (y >= d_y))
    {
        rect = true;  
    }else
    {
        rect = false;
    }
    
    if ((circ === false) && (rect === false)){
        console.log("outside circle outside rectangle");
    }
    
    if ((circ === false) && (rect === true)){
        console.log("outside circle inside rectangle");
    }
    
    if ((circ === true) && (rect === false)){
        console.log("inside circle outside rectangle");
    }
    
    if ((circ === true) && (rect === true)){
        console.log("inside circle inside rectangle");
    }
    
}

solve(['2.5', '2']);
solve(['0', '1']);
solve(['2.5', '1']);
solve(['1', '2']);
