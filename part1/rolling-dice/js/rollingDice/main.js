// Put your code here

function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

console.log("Let's roll some dice, baby!");
console.log("---------------------------");

for(let i=0; i < 10; i++)
{
    let die1 = getRandomInt(1, 6)
    let die2 = getRandomInt(1, 6) 

    let message = `${die1} + ${die2} == ${die1 + die2}`

    if(die1 === die2){
        message += " DOUBLES!"
    }

    console.log(message)
}



