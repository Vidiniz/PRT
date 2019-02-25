import axios from 'axios'

const url = 'http://localhost:49838/api/Todo'

export const changeDescription = event => ({
    type: 'DESCRIPTION_CHANGED',
    payload: event.target.value
})

export const search = () => {
    const request = axios.get(`${url}`) // ?sort=-createdAt
    return {
        type: 'TODO_SEARCHED',
        payload: request
    }
}

export const add = (description) => {
    const request = axios.post(url, { Description: description })
    return {
        type: 'TODO_ADDED',
        payload: request
    }
}