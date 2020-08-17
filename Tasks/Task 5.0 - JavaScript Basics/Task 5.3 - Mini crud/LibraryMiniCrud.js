module.exports = class Service {

    constructor() {
        this.storage = {};
        this.count = 0;
    }

    add(obj) {
        let id = `id-${this.count}`;
        this.storage[id] = obj;
        this.count++;
    }

    getById(id) {
        if (this.storage.hasOwnProperty(id)) {
            return this.storage[id];
        }
        else {
            return null;
        }
    }

    getAll() {
        let arrObj = [];
        for (let id in this.storage) {
            if (this.storage.hasOwnProperty(id)) {
                arrObj.push(this.storage[id]);
            }
        }
        return arrObj;
    }

    deleteById(id) {

        if (this.storage.hasOwnProperty(id)) {
            const delObj = this.storage[id];
            delete this.storage[id];
            this.count--;
            return delObj;
        }
        else {
            return null;
        }
    }

    updateById(id, obj) {
        if (this.storage.hasOwnProperty(id)) {
            if(typeof obj === 'object') {
                for (let prop in obj) {
                    this.storage[id][prop] = obj[prop];
                }
            }
            else {
                this.replaceById(id, obj);
            }
        }
        else {
            console.log("There is no object with this id!");
        }
    }

    replaceById(id, obj) {

        if (this.storage.hasOwnProperty(id)) {
            delete this.storage[id];
            this.storage[id] = obj;
        }
        else {
            console.log("There is no object with this id!");
        }
    }
}
