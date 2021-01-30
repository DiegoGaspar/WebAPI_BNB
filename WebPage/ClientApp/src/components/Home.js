import React, { Component } from 'react';
export class Home extends Component {
    
    static displayName = Home.name;

    render() {
        return (
            <Jumbotron fluid>
                <Container>
                    <h5>Para iniciar...</h5>
                    <p>
                        Faça o cadastro das salas e marque os agendamentos.
                    </p>
                </Container>
            </Jumbotron>
        );
    }
}
