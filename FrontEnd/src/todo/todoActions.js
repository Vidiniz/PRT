import axios from 'axios'

const url = 'http://localhost:49838/api/Todo'

const config = {
    headers: {
        'Access-Control-Allow-Origin': '*',
        'Content-Type': 'application/json'
    },
    withCredentials: true,
    credentials: 'same-origin',
    proxy: {
        host: 'localhost',
        port: 49838
    }
}

export const changeDescription = event => ({
    type: 'DESCRIPTION_CHANGED',
    payload: event.target.value
})

export const search = () => {
    return (dispatch, getState) => {
        const description = getState().todo.description
        const search = description ? `?description=${description}` : ''
        const request = axios.get(`${url}${search}`, { config })
            .then(resp => dispatch({ type: 'TODO_SEARCHED', payload: resp.data }))
    }
}

export const add = (description) => {
    return dispatch => {
        axios.post(url, { Description: description })
            .then(resp => dispatch(clear()))
            .then(resp => dispatch(search()))
    }
}

export const markedAsDone = (todo) => {
    return dispatch => {
        axios.put(`${url}/${todo.Id}`, { ...todo, Done: true })
            .then(resp => dispatch({ type: 'TODO_MARKED_AS_DONE', payload: resp.data }))
            .then(resp => dispatch(search()))
    }
}

export const markedAsPending = (todo) => {
    return dispatch => {
        axios.put(`${url}/${todo.Id}`, { ...todo, Done: false })
            .then(resp => dispatch({ type: 'TODO_MARKED_AS_PENDING', payload: resp.data }))
            .then(resp => dispatch(search()))
    }
}

export const remove = (todo) => {
    return dispatch => {
        axios.delete(`${url}/${todo.Id}`)
            .then(resp => dispatch(search()))
    }
}

export const clear = () => {
    return [{ type: 'TODO_CLEAR' }, search()]
}