# Patient Risk Analytics API

## Overview

Patient Risk Analytics API is a .NET Core-based web application that assesses cardiovascular health risks for patients based on various health factors. This API allows healthcare professionals to input patient data and receive a risk assessment score, helping in early detection and prevention of cardiovascular diseases.

## Features

1. **Patient Management**
   - Create new patient records
   - Retrieve patient information

2. **Risk Assessment**
   - Calculate a risk score for patients based on multiple health factors
   - Risk factors include age, BMI, existing conditions, cholesterol levels, blood pressure, and family history

3. **API Endpoints**
   - POST /Patient: Create a new patient record
   - GET /Patient/{id}: Retrieve information about a specific patient
   - GET /Patient/{id}/risk: Calculate and return the risk score for a specific patient

4. **Swagger UI Integration**
   - Interactive API documentation and testing interface

## Technology Stack

- .NET 8.0
- ASP.NET Core Web API
- Entity Framework Core (with In-Memory Database for demonstration)
- Swagger / OpenAPI

## Project Structure

- `Models/Patient.cs`: Defines the Patient data model
- `Services/RiskAssessmentService.cs`: Implements the risk assessment algorithm
- `Controllers/PatientController.cs`: Handles HTTP requests for patient operations
- `Data/PatientContext.cs`: Manages the database context
- `Program.cs`: Configures and runs the web application

## How It Works

### 1. Patient Data Input
- The API accepts patient data including age, BMI, medical conditions, cholesterol levels, blood pressure, and family history.

### 2. Risk Calculation
- The `RiskAssessmentService` calculates a risk score based on the provided patient data.
- Each risk factor contributes to the overall risk score.
- The final score is a value between 0 (0% risk) and 1 (100% risk).

### 3. Data Storage
- Patient data is stored in an in-memory database for demonstration purposes.
- In a production environment, this would be replaced with a persistent database.

### 4. API Interaction
- Users can interact with the API through HTTP requests or via the Swagger UI.

## Setup and Running

1. Clone the repository
2. Ensure you have .NET 8.0 SDK installed
3. Navigate to the project directory
4. Run `dotnet restore` to restore dependencies
5. Run `dotnet run` to start the application
6. Access the Swagger UI at `http://localhost:5000/swagger`

## API Usage

### 1. Create a Patient
- Use the POST /Patient endpoint
- Provide patient details in the request body

### 2. Retrieve Patient Information
- Use the GET /Patient/{id} endpoint
- Replace {id} with the patient's ID

### 3. Get Risk Assessment
- Use the GET /Patient/{id}/risk endpoint
- Replace {id} with the patient's ID

## Note

This is a prototype application for demonstration purposes. In a real-world scenario, it would require further development, security measures, and compliance with healthcare regulations like HIPAA.
