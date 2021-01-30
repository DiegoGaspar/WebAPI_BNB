import React, { Component } from 'react';
import { NavLink } from 'react-router-dom';
import { Navbar, Nav } from 'reactstrap';

export class Navegacao extends Component {
    render() {
        return (
            <Navbar bg="light" className="mt-3">
                <Navbar.Brand>Agendamento</Navbar.Brand>
                <Nav>
                    <Nav.Item>
                        <NavLink className="btn btn-outline-secondary m-1 navbar-btn" to="/Sala">Novo Serviço</NavLink>
                        <NavLink className="btn btn-outline-secondary m-1 navbar-btn" to="/Agenda">Agendamentos</NavLink>
                    </Nav.Item>
                </Nav>
            </Navbar>
        );
    }
}