Bekassyl Karazhan's Practical Problem Solving Task 

## Task
Implement a method to find the maximum number of non-overlapping delivery routes from a list of time intervals. Each route is represented by a start and end time.

public static int GetMaxNonOverlappingRoutes(List<(int start, int end)> routes)

## How it works
The GetMaxNonOverlappingRoutes method implements a greedy algorithm to find the optimal solution. The key steps are:

Sort by End Time: The algorithm first sorts all routes in ascending order based on their end times. This is the crucial greedy choice, as it allows us to always pick the next available route that finishes earliest.

Iterate and Select: It then iterates through the sorted list, selecting the first route.

Greedy Choice: For each subsequent route, it checks if its start time is greater than or equal to the end time of the last selected route.

Count Non-Overlaps: If it doesn't overlap, the route is selected, and the counter is incremented. The end time of this newly selected route becomes the new reference point for the next comparing.

This greedy approach makes finding the maximum number of non-overlapping routes. The code includes detailed Console.WriteLine statements to trace the algorithm's logic for each test case.

## Test Cases
The Main method includes several test cases to demonstrate the algorithm's functionality
Test 1: A basic example to show the core logic.
Test 2: Adjacent intervals (e.g., (1,2) and (2,3)), which are considered non-overlapping and valid.
Test 3: An empty list, which should correctly return a count of 0.
Test 4: All intervals overlap, resulting in only one selection.
Test 5: A mix of long and short intervals to verify the algorithm correctly picks the maximum non-overlapping set.