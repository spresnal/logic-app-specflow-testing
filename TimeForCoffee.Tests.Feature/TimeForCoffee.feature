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
	| StepName | Status  |
	| step1    | success |
