# CRUD Biometric System

This project is a CRUD (Create, Read, Update, Delete) biometric system that integrates with a MySQL database to manage user data, fingerprint data (FIR), and audit data. The system uses the NITGEN SDK for biometric operations.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Dependencies](#dependencies)
- [Functions](#functions)

## Features

- Insert, update, delete, and retrieve user data.
- Insert, update, delete, and retrieve fingerprint data (FIR).
- Insert, update, delete, and retrieve audit data.
- Biometric operations using NITGEN SDK.
- WMI event watchers for device management.

## Installation

### Prerequisites

- Visual Studio
- .NET Framework
- MySQL Server
- NITGEN SDK

### Steps

1. **Clone the repository:**
```Bash
git clone https://github.com/Leostruka/Nitgen_BiometricCRUD.git cd crud-biometric-system
```

3. **Open the project in Visual Studio:**
   - Open `CRUD_Biometric.sln` in Visual Studio.

4. **Configure the MySQL connection:**
   - Update the connection string in `DataAccess/Connection.cs` with your MySQL server details.

5. **Install MySQL Connector:**
   - Install the MySQL Connector for .NET from NuGet Package Manager.

6. **Build the project:**
   - Build the solution in Visual Studio to restore all dependencies and compile the project.

## Usage

1. **Run the application:**
   - Start the application from Visual Studio.

2. **Database Setup:**
   - Ensure your MySQL server is running.
   - Create the necessary tables (`user`, `fir`, `auditdata`) in your MySQL database.

3. **Interacting with the application:**
   - Use the provided UI to manage users, fingerprints, and audit data.

## Dependencies

- [MySQL Connector](https://dev.mysql.com/downloads/connector/net/)
- [NITGEN SDK](https://www.nitgen.com/eng/)

## Functions

### CRUD.cs

- `InitializeWmiWatchers()`: Initializes WMI event watchers.
- `InitializeFingerCheckWorkerFunctions()`: Initializes background worker functions for finger check.
- `ErrorMsg(uint ret)`: Displays error messages.
- `IsValidName(string name)`: Validates the user name.
- `StringToByteArray(string hex)`: Converts a hex string to a byte array.
- `GetSerialNumber(short deviceID)`: Retrieves the serial number of a device.
- `UpdateDGUsers()`: Updates the data grid of users.
- `UpdateIndexSearch()`: Updates the index search.
- `UpdateFirstSample()`: Updates the first sample.
- `AttSelectFir(int id, int sample)`: Selects a FIR.
- `AttActivateCapture(NBioAPI.Type.HFIR hFIR, NBioAPI.Type.HFIR hAuditFIR)`: Activates capture.
- `ConvertFIRToJpg(NBioAPI.Type.HFIR hFIR)`: Converts FIR to JPG.
- `ConvertFIRToJpg(AuditModel.Audit audit)`: Converts audit data to JPG.
- `ArrivalEventArrived(object sender, EventArgs e)`: Handles device arrival events.
- `RemovalEventArrived(object sender, EventArgs e)`: Handles device removal events.
- `fingerCheckWorker_DoWork(object sender, DoWorkEventArgs e)`: Background worker for finger check.
- `SearchDevice()`: Searches for devices.
- `bt_device_Click(object sender, EventArgs e)`: Handles device button click.
- `cb_autoOn_CheckedChanged(object sender, EventArgs e)`: Handles auto-on checkbox change.
- `bt_capture_Click(object sender, EventArgs e)`: Handles capture button click.
- `bt_register_Click(object sender, EventArgs e)`: Handles register button click.
- `bt_remove_Click(object sender, EventArgs e)`: Handles remove button click.
- `dg_users_SelectionChanged(object sender, EventArgs e)`: Handles user selection change.
- `tb_userID_TextChanged(object sender, EventArgs e)`: Handles user ID text change.
- `tb_sample_TextChanged(object sender, EventArgs e)`: Handles sample text change.
- `bt_returnSample_Click(object sender, EventArgs e)`: Handles return sample button click.
- `bt_nextSample_Click(object sender, EventArgs e)`: Handles next sample button click.
- `bt_modify_Click(object sender, EventArgs e)`: Handles modify button click.
- `bt_saveAlterUser_Click(object sender, EventArgs e)`: Handles save alter user button click.
- `bt_sampleReplace_Click(object sender, EventArgs e)`: Handles sample replace button click.
- `bt_saveAlterSample_Click(object sender, EventArgs e)`: Handles save alter sample button click.

### SQL.cs

- `InsertDataUser(UserModel.User user)`: Inserts user data into the database.
- `InsertDataFir(FIRModel.FIR fir)`: Inserts FIR data into the database.
- `InsertDataAudit(AuditModel.Audit audit)`: Inserts audit data into the database.
- `GetDataFir()`: Retrieves FIR data from the database.
- `GetDataUserFir()`: Retrieves user and FIR data from the database.
- `GetSpecificDataAudit(int id)`: Retrieves specific audit data from the database.
- `UpdateDataUser(UserModel.User user)`: Updates user data in the database.
- `UpdateDataFirAudit(FIRModel.FIR fir, AuditModel.Audit audit)`: Updates FIR and audit data in the database.
- `DeleteDataUser(int id)`: Deletes user data from the database.
- `DeleteDataFirAudit(int id, int sample)`: Deletes FIR and audit data from the database.

### Connection.cs

- `OpenConnection()`: Opens a connection to the MySQL database.
- `CloseConnection()`: Closes the connection to the MySQL database.

## License

This project is licensed under the MIT License. See the [LICENSE](https://github.com/Fingertech-Brasil/Nitgen_BiometricCRUD?tab=MIT-1-ov-file) file for details.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

## Contact

For any questions or inquiries, please contact [suporte@fingertech.com.br](mailto:suporte@fingertech.com.br)
