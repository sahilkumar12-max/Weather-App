                                                                                                # Weather Forecast Application

## Overview

This Weather Forecast application is a desktop application developed in C# using Windows Forms. It enables users to retrieve and display real-time weather information for a specified city, utilizing the OpenWeatherMap API.

## Features

- **City Input**: Enter the name of the city to retrieve weather information.

- **Weather Information Display**: Display details such as temperature, weather conditions, description, wind speed, humidity, pressure, sunrise, and sunset.

- **Weather Icon**: Visual representation of current weather conditions.

## How to Use

1. **API Key Setup**: Obtain an OpenWeatherMap API key and replace the placeholder in the code.

2. **Run the Application**: Execute the application to open the main window.

3. **Enter City Name**: Type the city name in the provided text box.

4. **Get Weather**: Click the "Submit" button to fetch and display weather information.

5. **View Weather Details**: Details include maximum temperature, weather conditions, description, wind speed, humidity, pressure, sunrise, and sunset.

6. **Weather Icon**: An icon visualizes the current weather conditions.

## Code Structure

The application consists of two main files:

- **`weatherinfo.cs`**: C# classes representing the structure of the JSON response from OpenWeatherMap API.

- **`btn.cs`**: Main form handling UI interactions and weather information retrieval.

## External Libraries Used

- **Newtonsoft.Json**: Used for deserializing JSON responses from the OpenWeatherMap API.

## Getting Started

1. Clone the repository:

    ```bash
    git clone https://github.com/your-username/weather-forecast-app.git
    ```

2. Open the project in a C# development environment (e.g., Visual Studio).

3. Replace the placeholder API key in the `btn.cs` file.

4. Build and run the application.

## Acknowledgments

- This application serves as a simple example and can be extended with additional features.

Feel free to modify and enhance the application as needed for your use case!

## Contact

For inquiries or issues, please contact Sahilku86680604@gmail.com.
