import React, { Component } from 'react';

export class Employees extends Component {
  static displayName = Employees.name;

  constructor(props) {
    super(props);
    this.state = { employees: [], loading: true };
  }

  componentDidMount() {
    this.populateEmployeeData();
  }

  static renderEmployeesTable(employees) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr> 
            <th>Organisation Number</th>
            <th>FirsName</th>
            <th>LastName</th> 
        </tr>
        </thead>
        <tbody>
          {employees.map(employee =>
            <tr key={employee.employeeId}>
              <td>{employee.organisationNumber}</td>
              <td>{employee.firstName}</td>
              <td>{employee.lastName}</td>
        </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Employees.renderEmployeesTable(this.state.employees);

    return (
      <div>
        <h1 id="tabelLabel">Employees</h1>
        <p>This component display managed employees.</p>
        {contents}
      </div>
    );
  }

  async populateEmployeeData() {
    const response = await fetch('api/employee');
    const data = await response.json();
    this.setState({ employees: data, loading: false });
  }
}
