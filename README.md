# CodeRetreat-Conway-s-Game-of-Life-Problem
This is a clean start to the Conway's Game of Life.

Information for attempting to solve the problem:
Problem: The game of Life, Conway

Saturday, November 14, 2015
9:13 AM

Rules:

1. Any live cell with fewer than two live neighbours dies, as if caused by under-population.
2. Any live cell with two or three live neighbours lives on to the next generation.
3. Any live cell with more than three live neighbours dies, as if by over-population.
4. Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

From <https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life> 


Conway chose his rules carefully, after considerable experimentation, to meet these criteria:
	1. There should be no explosive growth.
	2. There should exist small initial patterns with chaotic, unpredictable outcomes.
	3. There should be potential for von Neumann universal constructors.
	4. The rules should be as simple as possible, whilst adhering to the above constraints.[9]

From <https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life> 

Cell < 2 Neighbours dies
Cell > 2 Neigbours lives or Cell > 3 neighbours lives
Cell > 3 Neighbours dies
Dead Cell == 3 live neighbors
