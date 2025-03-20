# Advanced Search Technology in Text Files (2024)

## Overview
This project implements advanced search technology for text files using modern tools and libraries. It combines server-side and client-side technologies to deliver a seamless and efficient search experience. The project is designed to handle complex search scenarios, including searching for sequences of words based on their **gematria** values.

## Features
- **Smart Window Algorithm**: Enables searching for gematria word sequences that can start and end anywhere in a verse.
- **Cross-Platform Implementation**:
  - **Server-Side**: Built with `C#` and `ASP.NET Web API`.
  - **Client-Side**: Developed using `JavaScript` and HTML.
  - **Desktop Application**: Additional implementation using `WinForms`.
- **Persistent Search History**:
  - **WinForms**: Uses `Form_Load` and `FormClosed` events to load and save search history from/to a JSON file.
  - **HTML**: Uses `onLoad` and `onBeforeUnload` events for similar functionality.
- **Interactive Search Results**:
  - Clicking on a previous search result displays the corresponding search data without performing a new search.
  - Utilizes the `sender` object and its internal properties for event handling.

## Technologies Used
- **Server-Side**:
  - `C#`
  - `ASP.NET Web API`
  - `Json Serializer`
  - NuGet libraries
- **Client-Side**:
  - `JavaScript`
  - `HTML`
  - `Axios` for HTTP requests
- **Desktop Application**:
  - `WinForms`
- **Data Format**:
  - JSON for storing and retrieving search history.

## Project Structure
- **Web API**: Handles server-side logic and provides endpoints for search operations.
- **Client-Side**: Implements the user interface and communicates with the server using AJAX requests.
- **WinForms Application**: Provides a desktop interface for performing searches and managing search history.

## Key Functionalities
1. **Search by Word**:
   - Allows users to search for a specific word in the text files.
   - Results include the verse, chapter, book name, and content.

2. **Search by Name**:
   - Searches for verses containing specific names.

3. **Search by Gematria**:
   - Single-word gematria search.
   - Multi-word gematria sequence search.

4. **Search History**:
   - Displays a table of recent searches.
   - Clicking on a search displays the results from that search.

5. **Persistent Data**:
   - Search history is saved to a JSON file when the application is closed and loaded when it starts.

## How to Run
1. **Server**:
   - Open the Web API project in Visual Studio.
   - Run the project to start the server on `https://localhost:7096`.

2. **Client**:
   - Open the HTML file in a browser.
   - Ensure the server is running to enable API communication.

3. **WinForms Application**:
   - Open the WinForms project in Visual Studio.
   - Run the application to access the desktop interface.

## API Endpoints
- `GET /api/Tanach/{word},{index}`: Search for a word in a specific book.
- `GET /api/Names/{name}`: Search for verses containing a specific name.
- `GET /api/lastSearch`: Retrieve the last search history.
- `GET /api/Delete`: Clear the search history.
- `GET /api/Load`: Load search history from a JSON file.
- `GET /api/UnLoad`: Save search history to a JSON file.

## Future Enhancements
- Add support for additional search algorithms.
- Improve the user interface for better usability.
- Implement authentication for secure access to search history.

## Credits
This project was developed as part of a 2024 initiative to explore advanced search technologies in text files. It leverages modern tools and libraries to deliver a robust and efficient solution.# Advanced Search Technology in Text Files (2024)

## Overview
This project implements advanced search technology for text files using modern tools and libraries. It combines server-side and client-side technologies to deliver a seamless and efficient search experience. The project is designed to handle complex search scenarios, including searching for sequences of words based on their **gematria** values.

## Features
- **Smart Window Algorithm**: Enables searching for gematria word sequences that can start and end anywhere in a verse.
- **Cross-Platform Implementation**:
  - **Server-Side**: Built with `C#` and `ASP.NET Web API`.
  - **Client-Side**: Developed using `JavaScript` and HTML.
  - **Desktop Application**: Additional implementation using `WinForms`.
- **Persistent Search History**:
  - **WinForms**: Uses `Form_Load` and `FormClosed` events to load and save search history from/to a JSON file.
  - **HTML**: Uses `onLoad` and `onBeforeUnload` events for similar functionality.
- **Interactive Search Results**:
  - Clicking on a previous search result displays the corresponding search data without performing a new search.
  - Utilizes the `sender` object and its internal properties for event handling.

## Technologies Used
- **Server-Side**:
  - `C#`
  - `ASP.NET Web API`
  - `Json Serializer`
  - NuGet libraries
- **Client-Side**:
  - `JavaScript`
  - `HTML`
  - `Axios` for HTTP requests
- **Desktop Application**:
  - `WinForms`
- **Data Format**:
  - JSON for storing and retrieving search history.

## Project Structure
- **Web API**: Handles server-side logic and provides endpoints for search operations.
- **Client-Side**: Implements the user interface and communicates with the server using AJAX requests.
- **WinForms Application**: Provides a desktop interface for performing searches and managing search history.

## Key Functionalities
1. **Search by Word**:
   - Allows users to search for a specific word in the text files.
   - Results include the verse, chapter, book name, and content.

2. **Search by Name**:
   - Searches for verses containing specific names.

3. **Search by Gematria**:
   - Single-word gematria search.
   - Multi-word gematria sequence search.

4. **Search History**:
   - Displays a table of recent searches.
   - Clicking on a search displays the results from that search.

5. **Persistent Data**:
   - Search history is saved to a JSON file when the application is closed and loaded when it starts.

## How to Run
1. **Server**:
   - Open the Web API project in Visual Studio.
   - Run the project to start the server on `https://localhost:7096`.

2. **Client**:
   - Open the HTML file in a browser.
   - Ensure the server is running to enable API communication.

3. **WinForms Application**:
   - Open the WinForms project in Visual Studio.
   - Run the application to access the desktop interface.

## API Endpoints
- `GET /api/Tanach/{word},{index}`: Search for a word in a specific book.
- `GET /api/Names/{name}`: Search for verses containing a specific name.
- `GET /api/lastSearch`: Retrieve the last search history.
- `GET /api/Delete`: Clear the search history.
- `GET /api/Load`: Load search history from a JSON file.
- `GET /api/UnLoad`: Save search history to a JSON file.

## Future Enhancements
- Add support for additional search algorithms.
- Improve the user interface for better usability.
- Implement authentication for secure access to search history.

## Credits
This project was developed as part of a 2024 initiative to explore advanced search technologies in text files. It leverages modern tools and libraries to deliver a robust and efficient solution.
