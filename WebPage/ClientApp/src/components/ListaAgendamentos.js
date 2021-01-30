import React, { Component } from 'React'
import { Link } from 'react-router-dom'

export class ListaAgendamentos extends Component {
    static displayName = "Lista de Agendamento";

    constructor() {
        super();
        this.state = { Agendamento: [], loading: true }
    }

    componentDidMount() {
        this.popularAgendamentos();
    }

    static agendaEditar(id) {
        window.location.href = 'api/Agendamentos/' + id;
    }

    static agendaDeletar(id) {
        if (!window.confirm('Deseja deletar o agendamento ' + id)) {
            return;
        } else {
            fetch('api/Agendamentos' + id, { method: 'delete' }).then(json => {
                window.location.href = '/lista-agendamento'; alert('Agendamento deletado!');
            })
        }
    }

    static renderListaAgendamentos(agenda) {
        return (
            <table id='table-agendamentos' className='table table-triped' aria-labelledby='tableAgendamentoTitulo'>
                <thead>
                    <tr>
                        <th>Código</th>
                        <th>Data</th>
                        <th>Horario Inicial</th>
                        <th>Horario Final</th>
                        <th>Placa do veículo</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    {agenda.map(age =>
                        <tr key={age.id}>
                            <td>{age.id}</td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>
                                <button className='btn btn-success' onClick={(id) => this.agendaEditar(age.id)}>Editar</button> &nbsp;
                                <button className='btn btn-danger' onClick={(id) => this.agendaDeletar(age.id)}>Deletar</button>;
                            </td>
                        </tr>

                    )}
                </tbody>
            </table>
        );
    }

    render () {
        let contents = this.state.loading
            ? <p><em> Carregando...</em></p>
            : ListaAgendamentos.renderListaAgendamentos(this.state.agendamentos);
        return (
            <div>
                <h1 id='tableAgendamentoTitulo'>Agendamentos</h1>
                <p>Tela de Agendamentos</p>
                <p>
                    <Link>Retornar</Link>
                </p>

                {contents}
            </div>
        );
    }

    async popularAgendamentos() {
        const response = await fetch('api/Agendamentos');
        const data = await response.json();
        this.setState({ Agendamento: data, loading: false });
    }
}