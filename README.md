# Issue Reproduction

- Pull repository

- Visual Studio
  - Open `SampleProject.slnx`
  - Build Solution

- Windows
  - Add hosts entry; e.g. `127.0.0.1  SampleProject`

- IIS:

  - Application Pools
    - Add Application Pool
      - Name: `SampleProject`
      - .NET CLR version: `No Managed Code`
      - Managed pipeline mode: `Integrated (Default)`
      - Start application pool immediately: `False`
	  - Click OK
	  - Advanced Settings
	    - Start Mode: `AlwaysRunning`
	    - Idle Time-out (minutes): `0`
		- Click OK

  - Sites
    - Add Website
		- Site name: `SampleProject`
		- Application pool: `SampleProject`
		- Physical path: `%PATH_TO_REPO%\SampleProject`
		- Binding
		  - Type: `http (Default)`
		  - IP address: `All Unassigned (Default)`
		  - Port: `80 (Default)`
		  - Host name: `SampleProject`
		- Start Website immediately: `False`
		- Click OK
        - Advanced Settings
	      - Preload Enabled: `True`
		  - Click OK
		  
  - Start App Pool `SampleProject`
  - Start Website `SampleProject`
  
- Browser
  - Navigate to: `http://sampleproject/`
  - Confirm response: `Hello World!`
  
- Windows
  - Note current time
  - Shutdown / Restart
  - Confirm hang state; shutdown never completes
  - Hard power off and restart
  - Event Viewer
    - Windows Logs -> Application 
	  - Filter Source = `IIS AspNetCore Module V2`
	  - Check entries for time of Shutdown / Restart
	  - Confirm App Pool in stop / start loop preventing Windows shutdown
