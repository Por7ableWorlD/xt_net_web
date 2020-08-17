var Service = require('./LibraryMiniCrud.js');

const storage = new Service();

const first = {
    name: 'Vasya',
    age: 10,
}

const second = {
  name: 'Petya',
  age: 20,
}

let third = 333;

storage.add(first);
storage.add(second);
storage.add(third);

console.log('\nStorage:\n', storage);

console.log('\n==============\n');
const oneOfId = storage.getById('id-2');
console.log("Id-2:", oneOfId);

console.log('\n==============\n');
const array = storage.getAll();
console.log("All storage: ", array);

console.log('\n==============\n');
const deleted = storage.deleteById('id-1');
console.log('Storage: ', storage.getAll());
console.log('Deleted item: ', deleted);

console.log('\n==============\n');
const newObj = {age: 15, job: 'Microsoft'}
storage.updateById('id-0', newObj)

console.log('Storage:\n', storage)

console.log('\n==============\n');
storage.replaceById('id-2', 444)
console.log('Storage:\n', storage)
