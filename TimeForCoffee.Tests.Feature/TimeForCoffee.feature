Feature: TimeForCoffee
	In order to drink the right amount of coffee
	As a developer
	I want to be told how many cups to drink

Scenario: TimeForCoffee noon test
	Given I send a POST request to 'https://prod-78.eastus.logic.azure.com:443/workflows/336e6cfc4b1c4006ab19fe38402e62ee/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=hwtWJD-ccugxtRd7FeeYjEcdm8rSmSAvzfLkYgMHBd8' with the body
	| currentTime |
	| 12:00       |
