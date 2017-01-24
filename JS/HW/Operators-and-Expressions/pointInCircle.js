function solve(args){
    var x = +args[0];
    var y = +args[1];
    
    var radius = 2;
    
    //d=SQRT((xp−xc)2+(yp−yc)2)
    var distance = Math.sqrt(x*x + y*y);
     
    var inside = distance <= radius;
    if(inside){
       console.log("yes " + distance.toFixed(2)); 
    }else {
        console.log("no " + distance.toFixed(2));
    }
}


solve(['-2', '0']);
solve(['-1', '2']);
solve(['1.5', '-1']);
solve(['1.5', '-1']);
solve(['-1.5', '-1.5']);
solve(['100', '-30']);
solve(['0', '0']);
solve(['0.2', '-0.8']);
solve(['0.9', '-1.93']);
solve(['1', '1.655']);
solve(['0', '1']);