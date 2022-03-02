## Modification

1. orthographical Correction
2. in domain no need to have extras namespace Models
3. don't use repository in controllers, i said it and i will insist on it. you passe pass through service (Application Layer), in order to handle some validation
4. Creating Services and their Abstractions
5. !!!!! Domain MUST BE PURE !!! its means, it should not be dependent to another to technical dependencies, in this case you have created a db context in the domain project its not a good idea.
6. I have told to to have always connection string in configuration file
7. Renaming Task To Todo Task because Task already exist in .net for handling async calls
8. using service in controller, returning not found if not task has been found. 
9. In EntityFramework, its preferable to separate mapping and DbContext (Open/Close principle) See Mapping Folder. 
10. Creating a project called Repository.EntityFramework because its specific to entityFramework. 
11. 


#Nice to have: 
1. introduce Unit of work pattern.
2. Add logging
