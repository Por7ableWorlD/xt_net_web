let string = "У попа была собака!";

function ChangerString(string) {
  let temporary = string.toLowerCase();
  let deletingCharacters = new Array;

  temporary = temporary.split(' ')

  for (let words of temporary) {
      for (let character of words) {
        if (!deletingCharacters.includes(character) && words.indexOf(character) != words.lastIndexOf(character)) {
            deletingCharacters.splice(0, 0, character);
            }
          }
      }

  let result = new Array;

  for (let character of string) {
      if (!deletingCharacters.includes(character.toLowerCase())) {
          result.push(character)
      }
  }

  console.log("Input :", string);
  console.log("Output:", result.join(''));
}

ChangerString(string);
