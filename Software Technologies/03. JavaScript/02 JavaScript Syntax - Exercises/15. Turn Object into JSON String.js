function solve(args) {
    let studentsData = args
        .map(studentString => studentString.split(' -> '));

    let student = {};

    studentsData.forEach(tokens => {
        let key = tokens[0];
            let value = tokens[1];

            if (['grade', 'age'].includes(key)){
                value = Number(value);
            }
                student[key] = value;
    });

            console.log(JSON.stringify(student));
}
solve([
    'name -> Angel',
    'surname -> Georgiev',
    'age -> 20',
    'grade -> 6.00',
    'date -> 23/05/1995',
    'town -> Sofia'
]);