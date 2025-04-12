# User stories
This document outlines the user stories for the project. Each user story is a high-level description of a feature from the perspective of an end user. The goal is to capture the requirements and expectations of users to guide the development process.

## TS001: Retrieve Greeting via GET Request
**As a** developer,
**I want to** retrieve a greeting message from the server using a GET request,
**So that** I can verify that the server is running and responding correctly.
### Acceptance Criteria
- **Scenario 1: Successful Greeting**
    - **Given** the server is running,
    - **When** I send a GET request to the `/greet` endpoint,
    - **Then** I should receive a 200 OK response with a greeting message in the body.
