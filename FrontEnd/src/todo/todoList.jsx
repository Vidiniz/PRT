import React from 'react'
import { connect } from 'react-redux'
import { bindActionCreators } from 'redux'
import IconButton from '../template/iconButton'
import { markedAsDone, markedAsPending, remove } from './todoActions'


const TodoList = props => {
    const renderRows = () => {
        const list = props.list || []
        return list.map(todo => (
            <tr key={todo.Id}>
                <td className={todo.Done ? 'markedAsDone' : ''}>{todo.Description}</td>
                <td>
                    <IconButton style="success" icon="check" hide={todo.Done}
                        onClick={() => props.markedAsDone(todo)}></IconButton>
                    <IconButton style="warning" icon="undo" hide={!todo.Done}
                        onClick={() => props.markedAsPending(todo)}></IconButton>
                    <IconButton style="danger" icon="trash-o" hide={!todo.Done}
                        onClick={() => props.remove(todo)}></IconButton>
                </td>
            </tr>
        ))
    }

    return (
        <table className="table">
            <thead>
                <tr>
                    <th>Descrição</th>
                    <th className="tableActions">Ações</th>
                </tr>
            </thead>
            <tbody>
                {renderRows()}
            </tbody>
        </table>
    )
}

const mapStateToProps = state => ({ list: state.todo.list })
const mapDispatchToProps = dispatch => bindActionCreators({ markedAsDone , markedAsPending, remove }, dispatch)
export default connect(mapStateToProps, mapDispatchToProps)(TodoList)
