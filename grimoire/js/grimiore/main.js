// Put your code here
const GetAllSpells = () => {
    const allSpells = [
        { Name: "Turn enemy into a newt", IsEvil: true, EnergyRequired: 5.1 },
        { Name: "Conjure some gold for a local charity", IsEvil: false, EnergyRequired: 2.99 },
        { Name: "Give a deaf person the ability to heal", IsEvil: false, EnergyRequired: 12.2 },
        { Name: "Make yourself emperor of the universe", IsEvil: true, EnergyRequired: 100 },
        { Name: "Convince your relatives your political views are correct", IsEvil: false, EnergyRequired: 2921.5 },
    ];
    return allSpells;
};

const DisplaySpellBook = () => {
    console.log("Do you believe in magic?");
    console.log("------------------------");

    const allSpells = GetAllSpells();
    const goodBook = allSpells.filter((spell) => !spell.IsEvil);
    const evilBook = allSpells.filter((spell) => spell.IsEvil);

    console.log("Good Book");
    for (const book of goodBook) {
        console.log(`  ${book.Name}`);
    }
    console.log("");
    console.log("Evil Book");
    for (const book of evilBook) {
        console.log(`  ${book.Name}`);
    }
};

DisplaySpellBook();
