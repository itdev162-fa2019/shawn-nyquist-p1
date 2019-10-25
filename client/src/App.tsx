import React from 'react';
import './App.css';
import axios from 'axios';

class App extends React.Component {
  state = {
    poems: []
  }

  componentDidMount() {
    axios.get('http://localhost:5000/api/poems')
    .then((response) => {
      this.setState({
        poems: response.data
      })
    })
      .catch((error) => {
        console.error(`Error fetching data: ${error}`);
      })
  }

  // handleChange(e) {
    
  // }
  
  render() {
    const { poems } = this.state;

    return (
      <div className="App">
        <header className="App-header">Cool Poems</header>

          <main>
            <input type="text" className="input" /* onChange={this.handleChange} */ placeholder="Search(Inactive for now)"/>
              {poems.map((poem: any) =>
                <div key={poem.id}>
                  <h1>"{poem.title}" by {poem.author}</h1>
                  <p>{poem.body}</p>
                </div>
                )}
          </main>
      </div>
    );
  }
}

export default App;
