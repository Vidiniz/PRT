import React from 'react'
import PageHeader from '../template/pageHeader'
import TodoForm from './todoForm'
import TodoList from './todoList'

export default props => {
    return (
        <div>
            <PageHeader name="Tarefa" small="Cadastro"></PageHeader>
            <TodoForm />
            <TodoList />
        </div>
    )
}
