class Storage {

    constructor() {
        this.map = new Map();
    }

    add(arr) {

        if (arr instanceof Array) {

            let id = 0;

            for (let key of this.map.keys()) {
                if (parseInt(key) > id) {
                    id = parseInt(key);
                }
            }

            id += 1;
            this.map.set(`${id}`, arr);

            return id;    // Вернём присвоенный объекту ID для предоставления возможности поиска объекта в библиотеке по присвоенному ID
        }
        else {
            console.log('-Аргумент либо пуст, либо не массив!');

            return null;
        }
    }

    getById(id) {

        if (this.map.has(`${id}`)) {
            return this.map.get(`${id}`);
        }
        else {
            return null;
        }
    }

    getAll() {
      return this.map;
    }

    getByData(data) {
        let temp = new Map();
        data = data.toLowerCase()

        for (let key of this.map.keys()) {
            for (let item of this.map.get(key)) {

                item = item.toLowerCase();

                if (item.includes(data)) {
                    temp.set(key, this.map.get(key));
                }
            }
        }
        return temp;
    }

    deleteById(id) {

        if (this.map.has(`${id}`)) {
            this.map.delete(`${id}`);
        }
        else {
            console.log('-Элемент с данным id не найден в библиотеке или id задан не правильно!');
        }
    }

    updateById(id, arr) {

        if (this.map.has(`${id}`)) {
            if (arr instanceof Array) {
                for (let key in arr) {
                    if (this.map.get(`${id}`)[key] != arr[key]) {
                        this.map.get(`${id}`)[key] = arr[key];
                    }
                }
            }
            else {
                console.log('-Только массивы!');
            }
        }
        else {
            console.log('-Элемент с данным id не найден в библиотеке или id задан не правильно!');
        }
    }

    replaceById(id, arr) {

        if (this.map.has(`${id}`)) {
            if (arr instanceof Array) {
                this.map.set(`${id}`, arr);
            }
            else {
                console.log('-Только массивы!');
            }
        }
        else {
            console.log('-Элемент с данным id не найден в библиотеке или id задан не правильно!');
        }
    }
}
