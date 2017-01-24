function youngestPeople(args){
    var persons = [];

    for (var i = 0; i < args.length; i += 3) {
        persons.push({
            firstname: args[i],
            lastname: args[i + 1],
            age: +args[i + 2]
        });
    }

  var youngest = persons[0],
      minAge = youngest.age;

 for(var i = 0; i < persons.length; i++) {
        if(persons[i].age < minAge ) {
            youngest = persons[i];
            minAge = youngest.age;
        }
    }
     console.log(youngest.firstname + " " + youngest.lastname); 
}

youngestPeople([
  'Gosho', 'Petrov', '32',
  'Bay', 'Ivan', '81',
  'John', 'Doe', '42'
]);

youngestPeople([
  'Penka', 'Hristova', '61',
  'System', 'Failiure', '88',
  'Bat', 'Man', '16',
  'Malko', 'Kote', '72'
]);