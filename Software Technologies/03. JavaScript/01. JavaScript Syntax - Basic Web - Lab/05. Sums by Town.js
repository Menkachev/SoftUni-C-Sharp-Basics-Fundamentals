/**
 * Created by Admin on 30.3.2017 г..
 */
solve([
    '{"town":"Sofia","income": 200}',
    '{"town":"Varna","income": 120}',
    '{"town":"Pleven","income": 60}',
    '{"town":"Varna","income": 70}'
]);

function solve(args) {
    let objects = args.map(JSON.parse);
    let sums = {};

    for (let object of objects){
        if (object.town in sums)
            sums[object.town] += object.income;
        else
            sums[object.town] = object.income;
    }

    let towns = Object.keys(sums).sort();
    for (let town of towns) {
        console.log(`${town} -> ${sums[town]}`);
    }
}