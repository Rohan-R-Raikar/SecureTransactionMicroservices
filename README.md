# Secure Transaction Microservices Platform

## 📌 Overview
Secure Transaction Microservices Platform is a sample distributed system designed to demonstrate modern backend architecture using ASP.NET Core, secure communication strategies, and enterprise-grade design patterns.

This project focuses on showcasing:

- Microservices architecture
- Secure API communication
- Authentication & Authorization flows
- Encryption and message validation
- Background job processing
- Real-time notification delivery

This project is created as part of a professional portfolio to demonstrate practical knowledge of distributed systems and secure backend development.

---

## 🏗 Architecture Style
- Microservices Architecture
- Database Per Service Pattern
- API Gateway Pattern
- Event-driven and asynchronous processing

---

## 🧩 Services

### 🔐 Auth Service
Handles user authentication, token generation, and identity validation.

### 💳 Order / Transaction Service
Processes secure transactions, handles business logic, and manages encrypted transaction data.

### 📢 Notification Service
Delivers real-time notifications using SignalR and background processing.

### 🚪 API Gateway
Single entry point for all client requests. Responsible for routing, request validation, and security enforcement.

---

## 🔐 Security Highlights
- JWT-based Authentication
- OAuth2 / OpenID Connect Flow
- HMAC Request Validation
- AES Encryption for Sensitive Data
- Secure Token Handling
- Two-Factor Authentication (Planned)

---

## 🛠 Technology Stack

### Backend
- ASP.NET Core Web API
- Entity Framework Core
- SignalR
- Hangfire
- Ocelot API Gateway

### Security
- JWT
- OAuth2 / OIDC
- HMAC
- AES Encryption

### Tools
- Swagger / OpenAPI
- Postman
- Hangfire Dashboard
- Git Version Control

---

## 📁 Project Structure
```
SecureTransactionMicroservices
├── gateway
├── services
│ ├── AuthService
│ ├── OrderService
│ └── NotificationService
├── docs
└── SecureTransactionPlatform.sln
```

---

## 🚀 Current Status
Initial architecture and documentation completed.  
Service skeleton development in progress.

---

## 🎯 Project Goals
- Demonstrate secure distributed system design
- Showcase microservices communication patterns
- Highlight backend security implementation strategies
- Provide interview-ready architecture demonstration

---

## 📚 Documentation
Detailed documentation available inside the `/docs` folder.

---

## 👨‍💻 Author
Developed as part of professional backend portfolio.