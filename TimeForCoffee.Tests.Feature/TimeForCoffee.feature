Feature: TimeForCoffee
	In order to drink the right amount of coffee
	As a developer
	I want to be told how many cups to drink

Scenario: TimeForCoffee noon test
	When I send a POST request to 'TimeForCoffee' with the body
	| currentTime |
	| 12:00       |
	And I wait '5' seconds for execution to complete
	Then I can verify the following logic app events for 'TimeForCoffee'
	| StepName                       | Status    |
	| manual                         | Succeeded |
	| Initialize_CupsOfCoffeeToDrink | Succeeded |
	| Get_hour_from_currentTime      | Succeeded |
	| Should_get_a_cup_of_coffee     | Succeeded |
	| Determine_number_of_cups       | Succeeded |
	| Number_of_cups_to_drink        | Succeeded |
	| Set_CupsOfCoffeeToDrink        | Succeeded |
	| Until                          | Succeeded |
	| Drink_cup_of_coffee            | Succeeded |
	| Decrement_CupsOfCoffeeToDrink  | Succeeded |
	| Too_late_for_coffee            | Skipped   |

