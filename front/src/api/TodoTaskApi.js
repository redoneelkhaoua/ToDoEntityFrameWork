import { handleResponse, handleError } from "./apiUtils";
const baseUrl = process.env.REACT_APP_API_URL + "/tasks/";

export function getTasks() {
  return fetch(baseUrl)
    .then(handleResponse)
    .catch(handleError);
}

export function saveTask(todoTask) {
  return fetch(baseUrl + (todoTask.id || ""), {
    method: todoTask.id ? "PUT" : "POST", // POST for create, PUT to update when id already exists.
    headers: { "content-type": "application/json" },
    body: JSON.stringify(todoTask)
  })
    .then(handleResponse)
    .catch(handleError);
}

export function editTask(todoTask) {
  return fetch(baseUrl + (todoTask.id || ""), {
    method: todoTask.id ? "PUT" : "PATCH", // POST for create, PUT to update when id already exists.
    headers: { "content-type": "application/json" },
    body: JSON.stringify(todoTask)
  })
      .then(handleResponse)
      .catch(handleError);
}

export function deleteTask(taskId) {
  return fetch(baseUrl + taskId, { method: "DELETE" })
    .then(handleResponse)
    .catch(handleError);
}
