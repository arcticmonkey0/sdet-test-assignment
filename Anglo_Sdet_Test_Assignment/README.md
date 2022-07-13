Solution consists of 2 projects:
1. Anglo_API - API TAF (based on .net framework 4.8), C# + RestSharp + SpecFlow + NUnit to test the ShowroomService.
2. Anglo_UI - UI TAF based on TypeScript + Playwright + Cucumber.js to test the https://automationteststore.com/

To run Anglo_API, just open the solution in Visual Studio then build it. Tests will appear in Test Explorer window which you can then just run.
To run Anglo_UI, open terminal in Anglo_UI folder and execute following commands: npm install, npm run build, npm run test.