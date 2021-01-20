import React, { Component } from 'react';

export class Organisations extends Component {
  static displayName = Organisations.name;

  constructor(props) {
    super(props);
    this.state = { organisations: [], loading: true };
  }

  componentDidMount() {
    this.populateOrganisationData();
  }

  static renderOrganisantionsTable(organisations) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Organisation Name</th>
            <th>Organisation Number</th>
            <th>AddressLine1</th>
            <th>AddressLine2</th>
            <th>AddressLine3</th>
            <th>AddressLine4</th>
            <th>Town</th>
            <th>Postcode</th>
            <th>House</th> 
        </tr>
        </thead>
        <tbody>
          {organisations.map(organisation =>
            <tr key={organisation.organisationNumber}>
              <td>{organisation.organisationName}</td>
              <td>{organisation.organisationNumber}</td>
              <td>{organisation.addressLine1}</td>
              <td>{organisation.addressLine2}</td>
              <td>{organisation.addressLine3}</td>
              <td>{organisation.addressLine4}</td>
              <td>{organisation.town}</td>
              <td>{organisation.postcode}</td>
              <td>{organisation.house}</td>
        </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Organisations.renderOrganisantionsTable(this.state.organisations);

    return (
      <div>
        <h1 id="tabelLabel">Organisations</h1>
        <p>This component display managed organisations.</p>
        {contents}
      </div>
    );
  }

  async populateOrganisationData() {
    const response = await fetch('api/organisation');
    const data = await response.json();
    this.setState({ organisations: data, loading: false });
  }
}
