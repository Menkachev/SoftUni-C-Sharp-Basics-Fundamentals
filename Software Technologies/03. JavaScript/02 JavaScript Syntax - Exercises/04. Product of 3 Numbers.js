function solve(args) {
    args = args.map(Number);
    let negativeCounter = 0;

    for (i = 0; i < args.length; i++){
        if (args[i] == 0){
            console.log('Positive');
            return;
        }
        if (args[i] < 0) {
            negativeCounter++;
        }
    }

   console.log(negativeCounter % 2 == 0 ? 'Positive' : 'Negative');

}

solve([-3, -4, 5]);
