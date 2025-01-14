import React from 'react';
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';
import './App.css';

function App() {
  return (
    <Router>
      <div className="app">
        <nav>
          <Link to="/">Home</Link>
          <Link to="/practice">Practice</Link>
          <Link to="/questions">Questions</Link>
        </nav>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/practice" element={<Practice />} />
          <Route path="/questions" element={<Questions />} />
        </Routes>
      </div>
    </Router>
  );
}

function Home() {
  return (
    <div className="container">
      <h1>InterviewBetter Core</h1>
      <p>AI-powered interview preparation platform</p>
      <Link to="/practice" className="btn">Start Mock Interview</Link>
    </div>
  );
}

function Practice() {
  return (
    <div className="container">
      <h2>Mock Interview Session</h2>
      <p>Select a category and begin practicing.</p>
      <div className="session-placeholder">
        <p>Session flow will be implemented here.</p>
        <p>Features: question display, timer, response input, scoring.</p>
      </div>
    </div>
  );
}

function Questions() {
  return (
    <div className="container">
      <h2>Question Bank</h2>
      <ul>
        <li>Tell me about a time you faced a challenge.</li>
        <li>Explain a technical concept simply.</li>
        <li>How would you design a URL shortener?</li>
      </ul>
    </div>
  );
}

export default App;
