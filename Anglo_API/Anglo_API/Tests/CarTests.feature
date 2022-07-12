Feature: CarTests

As a user
I want to have an entrypoint about cars storage
So that I can fetch the ones I'm interested in by some criteria

Scenario: List of saloon cars
	Given I login as User
	When I get a list of cars by Saloon type
	Then I verify the received cars list is the same as following
		| Make     | Model | Year | Type   | Price | ZeroToSixty |
		| BMW      | 3.25i | 2013 | Saloon | 15000 | 9.5         |
		| Audi     | S4    | 2015 | Saloon | 17500 | 8.3         |
		| Mercedes | C200  | 2018 | Saloon | 25000 | 8.0         |