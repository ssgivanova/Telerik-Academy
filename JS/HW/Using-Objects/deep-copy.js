function clone(obj) {
    var newObj = JSON.stringify(obj);
    return JSON.parse(newObj);
}

function compareObjects(obj, objCopy) {
    console.log('a == b --> ' + (obj == objCopy));
}

var a = {name: 'Pesho', age: 21};

//Deep copy
var b = clone(a);
compareObjects(a, b);

//Not deep copy
var c = a;
compareObjects(a, c);