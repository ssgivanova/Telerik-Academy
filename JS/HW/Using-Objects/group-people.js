// Write a function that groups an array of people by age. The function must return an associative array, 
//with keys - the groups, and values - arrays with people in this groups Use function overloading (i.e. just one function)

// Example:

// var people = [
//   { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
//   { firstname: 'Bay', lastname: 'Ivan', age: 81 },
//   { firstname: 'John', lastname: 'Doe', age: 42 },
//   { firstname: 'Pesho', lastname: 'Pesho', age: 22 },
//   { firstname: 'Asdf', lastname: 'Xyz', age: 81 },
//   { firstname: 'Gosho', lastname: 'Gosho', age: 22 }
// ];

// var groupedByAge = group(people);

// groupedByAge must be:
// {
//   '22': [
//     { firstname: 'Pesho', lastname: 'Pesho', age: 22 },
//     { firstname: 'Gosho', lastname: 'Gosho', age: 22 }
//   ],
//   '32': [
//     { firstname: 'Gosho', lastname: 'Petrov', age: 32 }
//   ],
//   '42': [
//     { firstname: 'John', lastname: 'Doe', age: 42 }
//   ],
//   '81': [
//     { firstname: 'Bay', lastname: 'Ivan', age: 81 },
//     { firstname: 'Asdf', lastname: 'Xyz', age: 81 }
//   ]
// }

var _ = require("underscore");

var Person = (function () {

    var Person = function(firstName, lastName, age) {
        this.firstname = firstName;
        this.lastname = lastName;
        this.age = age;
    };
    return Person;
})();

function group (object, value) {
    var grouped = _.groupBy(object, value.toLowerCase());
    _.each(grouped, function(key, item) {

        var result = 'Group ' + item + ' [ ';
        _.each(key, function(someKay) {
            result += someKay.firstname + ' ' + someKay.lastname + '(age ' + someKay.age + '), ';
        });
        result = result.substr(0, result.length-2) + ' ]';

        console.log(result);
    });
}

var persons = [];
persons.push(new Person("Scott", "Guthrie", 38));
persons.push(new Person("Scott", "Johns", 36));
persons.push(new Person("Scott", "Hanselman", 39));
persons.push(new Person("Jesse", "Liberty", 57));
persons.push(new Person("Jon", "Skeet", 38));

group(persons, 'firstName');
