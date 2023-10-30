# SampleConsoleApp


Please write a code in C# to solve the below problem. You can choose to write any type of
application (Console, Web, Windows, etc). It should be easy to change inputs and get output for a
different set of numbers.
Your company is analyzing malware software which targets numerical record files.
The malware checks the value of each record and the values of some of its neighbors. The record is
replaced by 0 when it is smaller or equal to either of those neighbors.
For each number, it matches the following pattern, where position 'X', is compared to positions 'T':
T, _, _, X, _, _, _, T
Positions '_' represent neighbors that are ignored. Positions further beyond the 'T's, to the far left or
far right, are also ignored.
If the 'X' position is near the left or right border and has no 'T' position neighbor, only one side is
considered.
The malware finds all the positions first and only then sets them to 0. For example, if the
values in a record file are the following: new int[] { 19, 2, 0, 87, 1, 40, 80, 77, 77, 77, 77 }
The expected values after the malware runs are:
new int[] { 19, 0, 0, 87, 0, 0, 0, 77, 77, 0, 0 }
In this example, number 2 was removed because 40 is the bigger number.
Implement the Simulate function so that the malware behavior is replicated for further study.
