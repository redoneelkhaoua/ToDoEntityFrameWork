import React, {useEffect, useState} from "react";
import Header from "./Header";
import TaskList from "./TaskList";
import {deleteTask, editTask, getTasks, saveTask} from "../api/TodoTaskApi";
import TaskCreator from "./TaskCreator";



function TodoListApp(){
    const [currentTask, setCurrentTask] = useState({
        id: null,
        details: "",
        status: "not yet"
    })
    const [todos, setTodos] = useState([]);


    useEffect(() => {
        (async () => {
            const tasks = await getTasks();
            setTodos(tasks);
        })();
    }, [])

    // ## handlers
    function handleChangeCurrent(e) {
        e.preventDefault();
        setCurrentTask({...currentTask, details: e.target.value})
    }

    async function handeCreateTask(e) {
        e.preventDefault();
        const x = await saveTask(currentTask);
        setTodos([...todos, x])

    }

    function handleChangeList(todo) {
        const newList = [...todos]
        const index = newList.findIndex(x => x.id == todo.id);
        newList[index] = todo;
        setTodos(newList);
    }

    async function handleEditList(todo) {
        await editTask(todo);
    }

    async function handleDeleteList(todo) {
        await deleteTask(todo.id);
        setTodos(todos.filter(x => x.id != todo.id))
    }

    return <>
        <Header/>
        <TaskCreator todo={currentTask} onChange={handleChangeCurrent} onSubmit={handeCreateTask}/>
        <TaskList todos={todos}
               onChange={handleChangeList}
               onDelete={handleDeleteList}
               onEdit={handleEditList}
        />
    </>
}
export default TodoListApp
