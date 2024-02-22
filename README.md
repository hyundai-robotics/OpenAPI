### Introduce  
* We provied the `C#` sample program and source code utilizing Hi6 OpenAPI.
* Detailed explanations can be found at the [Hi6 OpenAPI HRBook](https://hrbook-hrc.web.app/#/view/doc-hi6-open-api/english/1-intro/1-concept/README) .

### Environment  
* Description based on `Window OS`. 
* supported Hi6 OpenAPI version  
    - `level 1`, released in 2023.12
* supported Hi6 Controller version
    - from `v60.24`

### Installation  
- Press the button ` (window)` + ` R `.
- Search the `cmd` then execute the `cmd` console.
- Clone this repository
    ```sh
    # change directory to the "Desktop".
    C:\Users> cd %HOMEDRIVE%%HOMEPATH%\Desktop
    
    # clone the reposiory
    C:\Users\DHL\Desktop> git clone https://github.com/hyundai-robotics/OpenAPI.git 
    ```

### Implementation  
- `.exe` is in the `Debug` folder. You can open with below shell command.
    ```sh
    C:\Users\DHL\Desktop> explorer %HOMEDRIVE%%HOMEPATH%\Desktop\OpenAPI\OpenAPI_Cs_WinForm\bin\Debug
    ```
- Double Click the `OpenAPI_Cs_WinForm.exe`  

### Program Preview  
- Executed program image  
    &rightarrow; ***connect to the hi6 controller (ip: 192.168.1.150)***

    ![01_program_img](https://github.com/hyundai-robotics/OpenAPI/assets/48194000/524169b3-2ac5-4b21-b6bb-0cef2f76b316)

- Description  
    &rightarrow; the sample program shows event logs and basic information from hi6 controller.  
    &rightarrow; In addition to this, you can also check information about the current pose, IO relay, etc.

    ![03_vtp_program_img](https://github.com/hyundai-robotics/OpenAPI/assets/48194000/0cedec91-0aaf-4455-8fd2-ae8c457d07bc)