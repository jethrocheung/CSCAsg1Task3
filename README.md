# CSCAsg1Task3

## Web API Document
Action | HTTP Method | Relative URI
-- | -- | --
Getting the user information for the account | GET | api/Account/UserInfo
Logging out of the current account | POST | api/Account/Logout
Manage Account information with return url and generate state. | GET | api/Account/ManageInfo?returnUrl={returnUrl}&generateState={generateState}
Change the Password for an existing account | POST | api/Account/ChangePassword
Set a password for a new account | POST | api/Account/SetPassword
Add an External Login Account | POST | api/Account/AddExternalLogin
Remove an Account | POST | api/Account/RemoveLogin
Getting an external Login Account Information with the provider and an error string. | GET | api/Account/ExternalLogin?provider={provider}&error={error}
Manage an external Account information with return url and generate state. | GET | api/Account/ExternalLogins?returnUrl={returnUrl}&generateState={generateState}
Register an account | POST | api/Account/Register
Register for an account with external login information. | POST | api/Account/RegisterExternal

## Postman Screenshots
![image](https://user-images.githubusercontent.com/40429653/60268591-5031fd00-991f-11e9-88b7-6cf00c274333.png)
![image](https://user-images.githubusercontent.com/40429653/60268629-68a21780-991f-11e9-8336-95d097d5309f.png)
![image](https://user-images.githubusercontent.com/40429653/60268651-76579d00-991f-11e9-9fb6-d74807fa3337.png)
![image](https://user-images.githubusercontent.com/40429653/60268791-ccc4db80-991f-11e9-9a8a-6e8bfd5257f4.png)
![image](https://user-images.githubusercontent.com/40429653/60268865-faaa2000-991f-11e9-8979-2c9b1e847997.png)
![image](https://user-images.githubusercontent.com/40429653/60269026-44930600-9920-11e9-9bf4-25bdee216ef3.png)
![image](https://user-images.githubusercontent.com/40429653/60269065-55dc1280-9920-11e9-8a5c-33f1eedc9705.png)
![image](https://user-images.githubusercontent.com/40429653/60269108-67251f00-9920-11e9-806c-2b5dbf99236b.png)
![image](https://user-images.githubusercontent.com/40429653/60269179-8ae86500-9920-11e9-9218-94d6860ce1bb.png)
![image](https://user-images.githubusercontent.com/40429653/60269232-a05d8f00-9920-11e9-966c-4ead1af99ed3.png)
![image](https://user-images.githubusercontent.com/40429653/60269340-dc90ef80-9920-11e9-9032-80ffb57f08b9.png)
![image](https://user-images.githubusercontent.com/40429653/60269394-f4687380-9920-11e9-9ecb-e1f2e1c93312.png)
![image](https://user-images.githubusercontent.com/40429653/60269423-01856280-9921-11e9-8a2a-94be55913f54.png)
![image](https://user-images.githubusercontent.com/40429653/60269458-12ce6f00-9921-11e9-9c04-ba19e9d05a49.png)
![image](https://user-images.githubusercontent.com/40429653/60270913-ef58f380-9923-11e9-9b60-df4b5992fce2.png)
![image](https://user-images.githubusercontent.com/40429653/60270943-00a20000-9924-11e9-8381-c28bfcd8a2ff.png)
![image](https://user-images.githubusercontent.com/40429653/60270981-13b4d000-9924-11e9-9a9f-2cb40bb6f450.png)
![image](https://user-images.githubusercontent.com/40429653/60271009-24654600-9924-11e9-8849-920187b761f5.png)
![image](https://user-images.githubusercontent.com/40429653/60271066-3c3cca00-9924-11e9-9676-9a8095d7e84c.png)
![image](https://user-images.githubusercontent.com/40429653/60271114-5676a800-9924-11e9-91bd-dae086ec3c70.png)
![image](https://user-images.githubusercontent.com/40429653/60271151-655d5a80-9924-11e9-8753-fe734e28eb43.png)
![image](https://user-images.githubusercontent.com/40429653/60271184-76a66700-9924-11e9-8a0e-ef4b49c3b1f5.png)
