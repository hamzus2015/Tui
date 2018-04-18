# Tui FileReader library
I haven't worked with Git before...I learn it in two days !

US1 : Read various file type
I used abstract class heirarchy to force subclasses to implement its reading method
Implement Text and XML file reader but not Json (the some logic apply)

US2 : read encoded content
I used strategy pattern to decrypt the content of a file
With a variation : passing the decryption algo directly to the method

US3 : Role-based security
This was a challenging point ! :) But I like it since I didn't implement a security model before
I havent finished the exercice,but I tried to implement a PermissionProvider responsable for authorizing a role based 
on a set of persmission loaded from a source (Memory,config file, database etc...)

Bonus US4: Haven't the time to compelete it 

Good exercice , curious to see another solution alternative

Thank you anyway for the test, this is eexactly the technical level I'm looking for.


