==Prerequisites==

1. .NET framework 4.8+
2. Visual Studio
3. Node.js

==Description==

Solution consists of 2 projects:
1. Anglo_API - API TAF based on C# + RestSharp + SpecFlow + NUnit to test the ShowroomService.
2. Anglo_UI - UI TAF based on TypeScript + Playwright + Cucumber.js to test the https://automationteststore.com/

==Run==

1. Clone the repository
2. To run Anglo_API, first start the ShowroomService. Then open the Anglo_Sdet_Test_Assignment solution in Visual Studio, build it. Tests will appear in Test Explorer window which you can then just run.
3. To run Anglo_UI, open terminal in Anglo_UI folder and execute following commands: npm install, npx playwright install, npm run build, npm test.

