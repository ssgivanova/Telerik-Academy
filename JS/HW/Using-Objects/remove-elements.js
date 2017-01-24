// Write a function that removes all elements with a given value. Attach it to the array type. Read about prototype and how to attach methods.

// var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
// arr.remove(1); // arr = [2,4,3,4,111,3,2,'1'];
// You will be given an array of strings. Remove all occurrences of the first element in the array in itself.
// The output should be the array with some elements removed
// Each string should be on a separate line

function removeElements(args){
    var searchElement = args[0],
        arr = [],
        resultArray = [];
    for (var i = 0; i < args.length - 1; i++)
    {
        arr[i] = args[i + 1];
    }
 
    Array.prototype.remove = function(searchElement) {
        for (var i = 0; i < this.length; i++)
        {
            if (this[i] == searchElement) // or ===
            {
                this.splice(i, 1);
                i--;
            }
        }
        return this;
    }
 
    resultArray = arr.remove(searchElement);
 
    for(var k = 0; k < resultArray.length; k++)
    {
        console.log(resultArray[k]);
    }
}


removeElements([1,2,1,4,1,1,1,1,3,4,1,111,3,2,1,'1']);
//removeElements([1,2,1,4,1,3,4,1,111,3,2,1,'3']);