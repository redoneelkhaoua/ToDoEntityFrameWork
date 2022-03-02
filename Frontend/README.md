# Todo App

####Remarks: 
1. backend url should be configurable. 
2. axios is not required the fetch method is already exists in new the new javascript
3. choose carefully between components style, Class | function | array function
4. Math random is not good idea for generating ids, use guids or let the database generate it for you
5. components modeling has not been correct, you should make a difference between kinds of components 
   1. presentational component, not smart => basically its markup
   2. container components witch are smart contains business logic, holds the state.
6. you should create a service class that handle http request for you i have created TodoTaskApi.js
7. you should not make http call everywhere use a service class and use it in container components



### `npm run start:dotnet`
run api using C# dotnet backend

### `npm start`
USING Mock API see tools/db.json
Runs the app in the development mode.\
Open [http://localhost:3000](http://localhost:3000) to view it in your browser.

The page will reload when you make changes.\
You may also see any lint errors in the console.

### `npm test`

Launches the test runner in the interactive watch mode.\
See the section about [running tests](https://facebook.github.io/create-react-app/docs/running-tests) for more information.

### `npm run build`

Builds the app for production to the `build` folder.\
It correctly bundles React in production mode and optimizes the build for the best performance.

The build is minified and the filenames include the hashes.\
Your app is ready to be deployed!

See the section about [deployment](https://facebook.github.io/create-react-app/docs/deployment) for more information.