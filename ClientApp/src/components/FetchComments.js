import React, { Component } from 'react';

export class FetchComments extends Component {
  static displayName = FetchComments.name;

  constructor(props) {
    super(props);
    this.state = { comments: [], loading: true };
  }

  componentDidMount() {
    this.populateComments();
  }

  static renderCommentsTable(comments) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Date</th>
            <th>Comment</th>
          </tr>
        </thead>
        <tbody>
          {comments.map(comment =>
            <tr key={comment.timeStamp}>
              <td>{comment.timeStamp}</td>
              <td>{comment.comment}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchComments.renderCommentsTable(this.state.Comments);

    return (
      <div>
        <h1 id="tabelLabel" >What's been said about us...</h1>
        <p>This component fetches data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateComments() {
    const response = await fetch('commentary');
    const data = await response.json();
    this.setState({ Comments: data, loading: false });
  }
}
