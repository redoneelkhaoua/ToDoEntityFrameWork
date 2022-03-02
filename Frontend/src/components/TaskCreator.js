import React from "react";

function TaskCreator({todo, onChange, onSubmit}) {
    const {id, details} = todo;
    return <>
        <form onSubmit={onSubmit}>

            <input lang="ar" type="text"
                   placeholder="Task to be done.." required
                   value={details}
                   onChange={onChange}
            />
            <button className="icon-plus" type="submit"/>
        </form>
    </>;
}

export default TaskCreator;