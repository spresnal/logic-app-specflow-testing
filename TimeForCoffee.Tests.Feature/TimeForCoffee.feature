Feature: TimeForCoffee
	In order to drink the right amount of coffee
	As a developer
	I want to be told how many cups to drink

Scenario: TimeForCoffee noon test
	Given I send a POST request to 'TimeForCoffee' with the body
	| currentTime |
	| 12:00       |
