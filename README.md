# InterviewBetter Core

AI-powered interview preparation platform. Practice mock interviews with structured questions, receive scored feedback, and track progress over time.

## Overview

InterviewBetter Core provides a clean foundation for building interview preparation tools. It includes a categorized question bank, a session-based practice flow, basic scoring, and extension points for AI evaluation.

## Features

- Categorized question bank (Behavioral, Technical, System Design)
- Mock interview session management
- Answer submission and basic scoring
- Progress tracking structure
- React frontend with practice flow
- Clean API contracts ready for AI integration

## Architecture

```
backend/
├── Api/                 # Controllers and endpoints
├── Application/         # Services and use cases
├── Domain/              # Models and entities
└── Infrastructure/      # Data and external services

frontend/
├── src/
│   ├── components/      # Reusable UI
│   ├── pages/           # Main views
│   ├── hooks/           # Custom React hooks
│   ├── services/        # API clients
│   └── styles/
```

## Tech Stack

- Backend: ASP.NET Core
- Frontend: React + Vite
- Storage: In-memory (easily replaceable with EF Core / SQLite)

## Getting Started

### Backend
```bash
cd backend/Api
dotnet run
```

### Frontend
```bash
cd frontend
npm install
npm run dev
```

## Roadmap

- [x] Core models and question bank
- [x] Session flow and scoring structure
- [x] Frontend practice interface
- [ ] AI evaluation service
- [ ] User accounts and history
- [ ] Analytics dashboard

## License

MIT
