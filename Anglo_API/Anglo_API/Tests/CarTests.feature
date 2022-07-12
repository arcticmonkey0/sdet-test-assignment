@ShowroomService
Feature: CarTests
As a user
I want to have an entrypoint about cars storage
So that I can fetch the ones I'm interested in by some criteria

Background:
	Given I login as User

Scenario: Fetch list of saloon cars
	When I get a list of cars by Saloon type
	Then I verify the received cars list is the same as following
		| Make     | Model | Year | Type   | Price | ZeroToSixty |
		| BMW      | 3.25i | 2013 | Saloon | 15000 | 9.5         |
		| Audi     | S4    | 2015 | Saloon | 17500 | 8.3         |
		| Mercedes | C200  | 2018 | Saloon | 25000 | 8.0         |

Scenario: fetch list of Hatchback cars
	When I get a list of cars by Hatchback type
	Then I verify the received cars list is the same as following
		| Make       | Model  | Year | Type      | Price | ZeroToSixty |
		| Ford       | Fiesta | 2012 | Hatchback | 3000  | 23.0        |
		| Volkswagen | Golf   | 2015 | Hatchback | 12000 | 12.0        |

Scenario: Fetch list of Suv cars
	When I get a list of cars by Suv type
	Then I verify the received cars list is the same as following
		| Make   | Model        | Year | Type | Price | ZeroToSixty |
		| Toyota | Land Cruiser | 2018 | Suv  | 45000 | 12.0        |

Scenario: Try to fetch list of Racing cars
	Then attempt to get a list of cars by Racing type results in an error

	