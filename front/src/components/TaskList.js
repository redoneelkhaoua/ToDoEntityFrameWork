import React from "react";
import Task from "./Task";

function TasksList({todos, onChange, onDelete, onEdit}) {
    return <>
        {todos.map((todo) =>
            <Task key={todo.id} todo={todo} onChange={onChange} onDelete={onDelete} onEdit={onEdit}></Task>
        )}
    </>
}

export default TasksList