TSimulator
==========

## what is TSimulator?
TSimulator is a program (proof of concept) made to simulate the traffic of a website trading just one stock. For the sake of simplicity, it assumes that the bids come through four connections, although this can be changed with little modification to the code. It uses a sorted list, as well as multithreading with background data synchronization.

## usage
To run the program, 

> $ ./TSimulator.exe history input output stream1 stream2 stream3 stream4


**history** 

- This file contains the sorted bids for the previous day.
- The first line contains an integer n: the number of bids in the file.
- The n following lines each contain an integer b: a bid value.
- These lines are sorted in increasing order.

**input**

- This is the control input file: it's an interactive file that sends commands to the program 
- The possible commands are: top, end. More details below.

**output**

- This is the control output file: it's an interactive file where the program writes requested data

**stream1, stream2, stream3, stream4**

- These are the bids streams: they are interactive files that periodically receive bids

### Bidding via a stream

> $ echo >> *num* >> *stream\_file\_name*

where *num* is the dollar amount of your bid and *stream\_file\_name* is the filename of your streaming text file.

### Commands via a stream

> $ echo >> *command* >> *input\_file\_name*

where *command* follows the syntax of a command and *input\_file\_name* is the filename entered as **input** in the initial program arguments.

###Commands

> top *numBids* *numOutput*

where *numBids* is the number of bids for the program to wait for before executing the **top** command, and *numOutput* is the number of top *numOutput* bids for the program to output to the specified **output** path.

> end

signifies that the trading day has finished and the program can safely exit. A history file of today's bids in ascending order is saved to the **history** path specified in the initial program arguments.


