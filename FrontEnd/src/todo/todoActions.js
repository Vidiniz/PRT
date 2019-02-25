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
    const request = axios.get(`${url}`, { config }) // ?sort=-createdAt
    return {
        type: 'TODO_SEARCHED',
        payload: request
    }
}

export const add = (description) => {
    return dispatch => {
        axios.post(url, { Description: description })
            .then(resp => dispatch({ type: 'TODO_ADDED', payload: resp.data }))
            .then(resp => dispatch(search()))
    }
}