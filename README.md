### 1. Hi6 Open API 에 대하여

HD현대로보틱스는 어플리케이션 개발자들이 편리하게 로봇 제어기(이하, Hi6)를 모니터링하고 원격으로 제어하기 위한 API 를 공개하고 있습니다. 이를 통해 개발자들은 Hi6 개발에 적용된 소스코드에 대한 깊은 이해 없이 연결된 다양한 데이터를 읽고 쓸 수 있습니다.  

아래 그림을 통해서 보다 Open API 의 역할이 어떤 것인지를 보다 쉽게 이해할 수 있습니다.

![05_open_api_flow](https://github.com/hyundai-robotics/OpenAPI/assets/48194000/63c74546-9ccd-415f-8bfe-00704d913606)

위 그림에서 주황색으로 표시된 부분들은 Open API 의 역할을 보여주고 있습니다.  

|화살표|설명|
|:---|:---|
|`실선` |개발자(클라이언트)가 정해진 4가지 방법(GET, POST, PUT, DELETE)을 이용하여 Hi6(서버)에 정보를 `요청`하는 것을 의미|
|`점선` |요청을 받은 제어기가 그에 맞는 `응답`을 json 혹은 text 형식으로 반환하는 것을 의미|

이처럼 개발자는 해당 문서의 Open API 를 활용해서 Hi6 와 이더넷으로 연결된 본인의 데스크탑, 노트북, 태블릿 pc 등을 http 와 REST API 기반으로 원격 제어 또는 모니터링을 할 수 있게 됩니다.


<br>


### 2. 시작하기 전에 꼭 확인하세요!

* 해당 소스 코드는 공개된 API 를 토대로 작성된 C# 기반의 WinForms 샘플 프로그램에 대한 소스코드를 제공하고 있습니다.<br>

* 적용된 Hi6 Open API는 초기 버전으로, 버전 5를 기준으로 작성되었습니다.

* 이후 지속적으로 버전 업데이트가 있을 수 있습니다. 버전이 업데이트 되는 경우, 해당 section 을 참고하시기 바랍니다.

* 본 문서에 설명된 API들은 별도의 지원버전 명기가 없으면 Hi6 V60.24-00부터 지원됩니다.

* 본 문서에 명시되지 않은 URL 및 속성은 동일 API 버전에서 예고없이 변경될 수 있으므로, 주의 바랍니다.

<br>  

### 3. C# 기반의 WinForms 샘플 프로그램

해당 레포지토리는 C# 기반의 프로그램을 제공하고 있습니다. 이를 통해 Hi6 OpenAPI를 어떻게 활용할 수 있는지 파악할 수 있습니다.  
직접 프로그램을 실행하고 디버깅을 하면서 어떻게 사용할 수 있는지 확인 가능합니다.

#### 3.1 프로그램 설치 

* a) 해당 레포지토리를 클론합니다.  
    - 윈도우 키 + cmd 검색  &rightarrow; 실행  
    - 하기 명령어 실행  
        ```sh
        # 바탕화면으로 이동
        C:\Users> cd %HOMEDRIVE%%HOMEPATH%\Desktop
        
        # 바탕화면에 레포지토리 클론
        C:\Users\kim\Desktop> git clone https://github.com/hyundai-robotics/OpenAPI.git 
        ```

* b) 프로그램 실행하기
    - 바탕화면 > OpenAPI > OpenAPI_Cs_WinForm > bin > Debug 폴더 열기
        ```#
        C:\Users\kim\Desktop> explorer %HOMEDRIVE%%HOMEPATH%\Desktop\OpenAPI\OpenAPI_Cs_WinForm\bin\Debug
        ```
    - `OpenAPI_Cs_WinForm.exe` 실행


#### 3.2 프로그램 프리뷰

- 제어기와 PC가 연결되어있는 상태에서 `Update ON` 을 클릭하면 아래처럼 `이벤트 로그`와 기타 상태 정보를 확인할 수 있습니다.  
<br>
![01_program_img](https://github.com/hyundai-robotics/OpenAPI/assets/48194000/524169b3-2ac5-4b21-b6bb-0cef2f76b316)


- 확인되는 정보는 아래와 같이, 실제 제어기에서 출력되는 로그들에 해당합니다.  
<br>
![03_vtp_program_img](https://github.com/hyundai-robotics/OpenAPI/assets/48194000/0cedec91-0aaf-4455-8fd2-ae8c457d07bc)

- 이 외에도 현재 포즈 정보, IO릴레이 등에 대한 정보 또한 확인할 수 있으며 이 모든 기능에 대한 소스코드는 해당 레포지토리에서 확인 가능합니다. 