enum Season {
    Winter = 1,
    Spring,
    Summer,
    Autumn
}

const SeasonName = new Map<number, string>([
    [Season.Winter, "Winter"],
    [Season.Spring, "Spring"],
]);

console.log(`Value ${Season.Winter} has text - ${SeasonName.get(Season.Winter)}`);

enum FileAccess {
    Read = 1,
    Write = 5,
    ReadWrite = Read - Write
}

console.log(FileAccess.ReadWrite);
