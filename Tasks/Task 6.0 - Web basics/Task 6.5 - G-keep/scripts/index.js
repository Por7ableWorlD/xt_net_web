let storage = new Storage();

let editor = document.querySelector('.editor-window-container');
let mainPageBody = document.querySelector('.body-container');
let saveButton = document.querySelector('.editor-window-savebutton');
let addButton = document.querySelector('.add-button');
let editorTitleField = document.querySelector('.editor-window-header-text');
let editorTextField = document.querySelector('.editor-window-textarea');

let curEditеdNote = null;

let hiddenNotes = [];
let removeInWork = [];
let restoreInWork = [];

storage.add(['Привет!', 'Ты можешь добавлять, изменять или искать свои заметки!'])
storage.add(['А ТАКЖЕЕЕЕ', 'Можно удалять лишнии заметки.'])
storage.add(['НУ И ЕСЕСЕНАААА', 'Можно\nписать\nпо\nодной\nстрочке\nхоть\nпо\nб\nу\nк\nв\nе\n:))))))'])

InjectAllNotesToPage();

function InjectAllNotesToPage() {

    let allNotes = storage.getAll();

    for (let key of allNotes.keys()) {
        AddNote(key, allNotes.get(key)[0], allNotes.get(key)[1]);
    }
}

function NoteClick(id) {

    curEditеdNote = id
    let selectedNote = storage.getById(id);
    editorTextField.value = selectedNote[1];
    editorTitleField.value = selectedNote[0];
    saveButton.textContent = 'Сохранить';
    editor.classList.add('editor-window-container-to-top');
}

function AddButtonClick() {
    editorTextField.value = '';
    editorTitleField.value = '';
    editor.classList.add('editor-window-container-to-top');
    saveButton.textContent = 'Создать';
}

function RemoveClick(event) {

    event.stopImmediatePropagation();

    if (confirm('Вы действительно хотите удалить заметку?')) {
        storage.deleteById(event.target.id);
        SmoothRemove(document.getElementById(event.target.id));
    }
}

function EditorSaveClick() {

    if (curEditеdNote != null){
        storage.updateById(curEditеdNote, [editorTitleField.value, editorTextField.value])

        let curNoteTitle = document.getElementById(`${curEditеdNote}-title`);
        let curNoteText = document.getElementById(`${curEditеdNote}-text`);
        curNoteTitle.textContent = editorTitleField.value;
        curNoteText.innerHTML = editorTextField.value.replace(/\n/g, '<br>');

        curEditеdNote = null;

    } else {

        let id = storage.add([editorTitleField.value, editorTextField.value]);
        let createdItem = AddNote(id, editorTitleField.value, editorTextField.value, true);

        SmoothRestore(createdItem, false);
    }

    EditorCloseButtonClick();
}

function EditorCloseButtonClick() {
    editor.classList.remove('editor-window-container-to-top');
}

function SearchInput(input) {

    let allNotes = storage.getAll();
    let filteredNotes = storage.getByData(input);
    let toRemove = [];
    let toRestore = [];

    for (let key of allNotes.keys()){
        if (!filteredNotes.has(key)) {
            toRemove.push(key);
        }
        else {
            if (hiddenNotes.includes(key)) {
                toRestore.push(key);
            }
        }
    }

    for (let id of toRemove) {
        if (document.getElementById(id) && !removeInWork.includes(id))
        {
            removeInWork.push(id);
            hiddenNotes.push(id);

            let itemToRemove = document.getElementById(id)

            SmoothRemove(itemToRemove);
        }
    }

    for (let id of toRestore) {

        if ((!document.getElementById(id)  || removeInWork.includes(id)) && !restoreInWork.includes(id))
        {
            restoreInWork.push(id);

            let highterItem;
            let itemToRestore;

            for (let item of document.getElementsByClassName('body-element')) {
                if (item.id >= id) {
                    highterItem = item;
                    break;
                }
            }

            if (highterItem) {

                itemToRestore = AddNote(id, allNotes.get(id)[0], allNotes.get(id)[1], true, highterItem);
            }
            else {
                itemToRestore = AddNote(id, allNotes.get(id)[0], allNotes.get(id)[1], true);
            }

            SmoothRestore(itemToRestore)
        }
    }
}

function AddNote(id, title, text, opacity = false, highterIndex = null) {

    let bodyElement = document.createElement('div');
    bodyElement.className = 'body-element';
    bodyElement.id = id;
    bodyElement.setAttribute('onclick', 'NoteClick(this.id)');

    if (opacity) {
        bodyElement.style.opacity = 0;
    }

    let bodyElementHeader = document.createElement('p');
    bodyElementHeader.className = 'body-element-header';
    bodyElementHeader.id = `${id}-title`;
    bodyElementHeader.appendChild(document.createTextNode(title));

    let bodyElementText = document.createElement('p');
    bodyElementText.className = 'body-element-text';
    bodyElementText.id = `${id}-text`;
    bodyElementText.innerHTML = text.replace(/\n/g, '<br>');

    let bodyRemoveButton = document.createElement('div');
    bodyRemoveButton.className = 'body-remove-button';
    bodyRemoveButton.id = id;
    bodyRemoveButton.setAttribute('onclick', 'RemoveClick(event)');

    let bodyRemoveButtonImg = document.createElement('img');
    bodyRemoveButtonImg.src = "./images/close.svg";
    bodyRemoveButtonImg.alt = "window closure icon";
    bodyRemoveButtonImg.id = id;
    bodyRemoveButtonImg.className = "body-remove-button-img";

    bodyRemoveButton.appendChild(bodyRemoveButtonImg);
    bodyElement.appendChild(bodyElementHeader);
    bodyElement.appendChild(bodyElementText);
    bodyElement.appendChild(bodyRemoveButton);

    if (highterIndex == null){
        mainPageBody.appendChild(bodyElement);
    } else {
        mainPageBody.insertBefore(bodyElement, highterIndex);
    }

    return bodyElement;
}

function SmoothRemove(itemToRemove) {

    let opacity = 1;

    let opacityDecreasing = setInterval(function() {
        if (opacity <= 0) {

            clearInterval(opacityDecreasing)
            mainPageBody.removeChild(itemToRemove);
            removeInWork.splice(removeInWork.indexOf(itemToRemove.id), 1);

            return;
        }

        itemToRemove.style.opacity = opacity;
        opacity -= 0.1;

    }, 35);
}

function SmoothRestore (itemToRestore, notNew = true) {

    let opacity = 0;

    let opacityIncreasing = setInterval(function() {

        if (opacity >= 1) {

            clearInterval(opacityIncreasing)

            if (notNew) {
                restoreInWork.splice(restoreInWork.indexOf(itemToRestore.id), 1);
                hiddenNotes.splice(hiddenNotes.indexOf(itemToRestore.id), 1);
            }

            return;
        }

        itemToRestore.style.opacity = opacity;
        opacity += 0.1;

    }, 35);
}
