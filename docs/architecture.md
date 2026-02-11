# System Architecture

## 📌 Architecture Overview
The system follows a Microservices Architecture where each service operates independently with its own database and responsibility.

The system is designed to simulate secure transaction processing in a distributed environment.

---

## 🏗 High Level Components

### API Gateway
Acts as a unified entry point for clients.

Responsibilities:
- Request routing
- Authentication validation
- HMAC signature verification
- Rate limiting (Planned)
- Request logging

---

### Auth Service
Responsible for identity management.

Responsibilities:
- User authentication
- Token issuance (JWT)
- OAuth2 / OIDC support
- Role and permission management

---

### Order / Transaction Service
Handles core business logic.

Responsibilities:
- Transaction processing
- Sensitive data encryption
- Background job execution
- Transaction state management

---

### Notification Service
Responsible for user notifications.

Responsibilities:
- Real-time updates using SignalR
- Background message processing
- Notification delivery handling

---

## 🧱 Architectural Patterns Used

### Database Per Service
Each microservice maintains its own database to ensure loose coupling and independent scaling.

---

### API Gateway Pattern
Centralizes client interaction and reduces service exposure.

---

### Asynchronous Processing
Hangfire will be used to handle:
- Transaction post-processing
- Notification dispatch
- Background auditing

---

## 🔄 Communication Flow

Client → API Gateway → Target Microservice  
Microservices → Notification Service → Client (SignalR)

---

## 📈 Scalability Considerations
- Services can scale independently
- Stateless service design
- Background job isolation

---

## 🧭 Future Enhancements
- Message broker integration
- Distributed tracing
- Container orchestration
