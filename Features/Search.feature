Feature: Search

As an end user 
I want to be able to search for keyword eg 'automation tester' and search result displays one or more search result

@lexisnexis
Scenario Outline: Verify Search result
    Given user is on lexisnexis page
    When user navigate to “<Link1>” page
        And user navigate to “<Link2>” page
        And user clicks on Search all jobs button
        And search for '<SearchKeyWord>' in the search box
    Then user verify there is at least one or more search result

    Examples: 
    | Link1    | Link2   | SearchKeyWord     |
    | About Us | Careers | automation tester |