# ToDo List Application

This is a simple ToDo List application built using Windows Forms in C# targeting .NET 8. The application allows users to manage tasks within different tabs, each containing a checklist of tasks.

![alt text](/1.PNG)

![alt text](/2.PNG)

## Features

- **Login Form**: Users must log in with a username and password to access the application.
- **Task Management**: Users can create tabs for different task categories and add tasks to each tab.
- **Task Editing**: Users can edit tasks within a tab.
- **Task Deletion**: Users can delete tasks from a tab.
- **Tab Management**: Users can create and delete tabs.

## Getting Started

### Prerequisites

- Visual Studio 2022
- .NET 8 SDK

### Installation

1. Clone the repository:
   
2. Open the solution file `ToDo-List.sln` in Visual Studio 2022.

3. Build the solution to restore the necessary packages.

### Running the Application

1. Set the `ToDo-List` project as the startup project.
2. Press `F5` to run the application.

### Usage

1. **Login**: Use the username `admin` and password `admin` to log in.
2. **Create a Tab**: Click the button to create a new tab and enter the tab name.
3. **Add a Task**: Select a tab, click the button to add a task, and enter the task description.
4. **Edit a Task**: Select a tab, check the task to edit, click the button to edit the task, and enter the new task description.
5. **Delete Tasks**: Select a tab, check the tasks to delete, and click the button to delete the tasks.
6. **Delete a Tab**: Select a tab and click the button to delete the tab.

## Project Structure

- `index.cs`: Contains the login form logic.
- `myTask.cs`: Contains the main form logic for managing tasks and tabs.
- `Program.cs`: The main entry point for the application.
- `ToDo-List.csproj`: The project file containing project configuration.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request with your changes.

## License

This project is licensed under the MIT License. See the `LICENSE` file for more details.

## Acknowledgements

- Thanks to the .NET community for their support and resources.


