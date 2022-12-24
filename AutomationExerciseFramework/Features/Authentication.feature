Feature: Authentication
	As a user
	I want to be able to authenticate to the app
	So I can work with restricted web app content

@mytag
Scenario: User can log in
	Given user opens sign in page
	  And enters correct credentials
	When user submits login form
	Then user will be logged in

Scenario: User can sign up
	Given user opens sign in page
	  And enters 'Marija' name and valid email adress
	  And user clicks on SignUp button
	When user fills in all required field
	  And submits the signup form
	Then user will get 'Account Created!' success message
	  And user will be logged in
