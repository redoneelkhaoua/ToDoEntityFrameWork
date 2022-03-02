import React, {useState} from "react";

function Task({todo, onChange, onDelete, onEdit, onDone}) {

    function handleOnChange(e) {
        e.preventDefault();
        const value = e.target.value;
        const newTodo = {...todo, details: value}
        onChange(newTodo)
    }

    function handleDone(e) {
        e.preventDefault();
        const newTodo = {...todo, status: todo.status === 'done' ? 'not yet' : 'done'}
        onChange(newTodo)
    }
    function handleDelete(e) {
        e.preventDefault();
        onDelete(todo)
    }

    function handleEdit(e) {
        e.preventDefault();
        handleOnChange(e);
        onEdit(todo)
    }

    return  <div className="task">
        <button className="buttonEdit" onClick={onEdit}><h6>Edit</h6></button>

        <input className={`list ${todo.status?.trim() === 'done' ? "finish" : ""}`}
               type="text"
               value={todo.details?.trim()}
               onChange={handleOnChange}
        />
        <div>
            <span className="icon-trash icon" onClick={handleDelete}> </span>

            <span className="icon-file_done icon" onClick={handleDone}> </span>
        </div>

    </div>
}


export default Task;