// Put your code here

const spells = [
    {
        Name: "Turn enemy into a newt",
        IsEvil: true,
        EnergyReqired: 5.1
    }, 
    {
        Name: "Conjure some gold for a local charity",
            IsEvil: false,
            EnergyReqired: 2.99
    },
    {
        Name: "Give a deaf person the ability to heal",
        IsEvil: false,
        EnergyReqired: 12.2
    },
    {
        Name: "Make yourself emperor of the universe",
        IsEvil: true,
        EnergyReqired: 100.0
    },
    {
        Name: "Convince your relatives your political views are correct",
        IsEvil: false,
        EnergyReqired: 2921.5
    }
]

const goodBook = spells.filter(singleSpell => singleSpell.IsEvil === false)
const evilBook = spells.filter(singleSpell => singleSpell.IsEvil === true)

// for(let singleSpell of spells){
//     singleSpell.IsEvil ? 
//     goodBook.push(singleSpell)
//     :
//     evilBook.push(singleSpell)
// }

console.log("Do you believe in magic?");
console.log("------------------------");

const displaySpellBooks = (spellBook) => {
    for(let singleSpell of spellBook)
    {
        console.log(`${singleSpell.Name}`)
    }
}
console.log("The Good Book of Spells")
displaySpellBooks(goodBook)
console.log("")
console.log("The Evil Book of Spells")
displaySpellBooks(evilBook)
