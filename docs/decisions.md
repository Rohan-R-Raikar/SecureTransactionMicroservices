# Architecture & Technology Decisions

This document explains the reasoning behind major design and technology choices.

---

## Why Microservices Architecture?
Microservices allow:
- Independent deployment
- Better scalability
- Clear service ownership
- Improved fault isolation

Chosen to simulate modern enterprise backend systems.

---

## Why API Gateway (Ocelot)?
Ocelot provides:
- Centralized routing
- Authentication enforcement
- Security policy implementation
- Simplified client interaction

---

## Why Database Per Service?
Ensures:
- Service independence
- Loose coupling
- Independent schema evolution

---

## Why JWT Authentication?
JWT provides:
- Stateless authentication
- Scalable authorization model
- Reduced session storage dependency

---

## Why Hangfire for Background Processing?
Hangfire allows:
- Reliable background job execution
- Retry handling
- Job monitoring dashboard
- Simplified async workflows

---

## Why SignalR for Notifications?
SignalR enables:
- Real-time communication
- Server-to-client push messaging
- Better user experience

---

## Why Encryption Implementation?
Encryption ensures:
- Protection of sensitive transaction data
- Compliance with secure data storage principles
- Defense against database compromise

---

## Why Focus on Security?
Secure backend design is critical for transaction systems.  
This project highlights practical security implementation strategies.

---

## Design Philosophy
The goal is to demonstrate:
- Clear architecture thinking
- Secure system design awareness
- Practical distributed system modeling
