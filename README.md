# Mona - Password Manager
Mona is a powerful password manager which is written on C# Programming Language using .NET 4.7 supported by SQL Local DB 2019. This password manager stands out by having access to a personalized profile that is protected by a strong hashing and encryption system. This password manager can be used to not only protect passwords but also used for file encryption. In addition, the passwords saved on browsers are also retrieved into the application.

## The following are the operations implemented on Mona,
- SignUp
- SignIn
- Create, Read, Update, Delete Passwords
- Copy Decrypted Passwords For Instant Use
- File Encryption and Decryption
- Update Master Password
- Export User Stored Passwords
- View Decrypted Version of Browser Passwords
- Export Browser Passwords
- Remember User Credentials
- SignOut

# Technical Details [Operations]:

## User Module:

- Passwords are Initially hashed with BCrypt Hashing Algorithm (Randomly Salted).
- Passwords are then encrypted using the AES-256 Algorithm.
## Password Module:

- Passwords are encrypted using the AES-256 Algorithm with Random Key for Users.

## File Module:

- Files are Encrypted and Decrypted Using 3DES Algorithm.

## USB Module:

- USB DevideID and DevicePNPID are combined and encrypted to verify with the suitable USB Device
- Encryption is done with the SHA512 Algorithm.

## Admin Module:

- Has access to all user records
- Create, Read, Update, Delete User Records
- Allowed to the Admin Module only if the Correct USB Device is plugged-in and verified.

## Browser Password Module:

- As an Initial Release, Google Chrome and Mozilla Firefox Browsers are only supported.
- The database files from both browsers are accessed through SQLLite Connection.
- The Passwords are shown in the decrypted version along with the appropriate username/email registered for a website.

## Technical Details [Implementation]:

## Framework:
Microsoft .NET 4.7.1

## Programming - Language:
C#

## Database:
LocalDB 2019

## Installer:
MSI Installer Created Using Advanced Installer

