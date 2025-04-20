

| Method                        | Job      | Runtime  | Src                  | Target               | Mean        | Error     | StdDev    | Allocated |
|------------------------------ |--------- |--------- |--------------------- |--------------------- |------------:|----------:|----------:|----------:|
| LevenshteinDistance           | .NET 8.0 | .NET 8.0 | ?                    |                      |    14.90 ns |  0.114 ns |  0.095 ns |         - |
| LevenshteinDistanceOperations | .NET 8.0 | .NET 8.0 | ?                    |                      |    13.88 ns |  0.163 ns |  0.144 ns |         - |
| ToLevenshteinDistance         | .NET 8.0 | .NET 8.0 | ?                    |                      |    38.66 ns |  0.801 ns |  1.315 ns |      96 B |
| LevenshteinDistance           | .NET 8.0 | .NET 8.0 | ?                    | chara(...)s key [23] |    26.15 ns |  0.193 ns |  0.171 ns |         - |
| LevenshteinDistanceOperations | .NET 8.0 | .NET 8.0 | ?                    | chara(...)s key [23] |   466.49 ns |  8.998 ns | 10.362 ns |    1392 B |
| ToLevenshteinDistance         | .NET 8.0 | .NET 8.0 | ?                    | chara(...)s key [23] |   519.98 ns | 10.230 ns | 20.897 ns |    1696 B |
| LevenshteinDistance           | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] |                      |    33.69 ns |  0.312 ns |  0.277 ns |         - |
| LevenshteinDistanceOperations | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] |                      |   441.30 ns |  8.695 ns | 13.791 ns |    1328 B |
| ToLevenshteinDistance         | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] |                      |   470.45 ns |  9.414 ns | 20.265 ns |    1616 B |
| LevenshteinDistance           | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] | chara(...)s key [23] | 4,526.27 ns | 53.675 ns | 50.208 ns |         - |
| LevenshteinDistanceOperations | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] | chara(...)s key [23] | 5,037.79 ns | 78.733 ns | 73.647 ns |    1424 B |
| ToLevenshteinDistance         | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] | chara(...)s key [23] | 5,233.83 ns | 56.810 ns | 53.140 ns |    1736 B |


| Method                        | Job      | Runtime  | Src                  | Target               | Mean        | Error     | StdDev    | Allocated |
|------------------------------ |--------- |--------- |--------------------- |--------------------- |------------:|----------:|----------:|----------:|
| LevenshteinDistance           | .NET 9.0 | .NET 9.0 | ?                    |                      |    14.37 ns |  0.120 ns |  0.100 ns |         - |
| LevenshteinDistanceOperations | .NET 9.0 | .NET 9.0 | ?                    |                      |    13.81 ns |  0.153 ns |  0.144 ns |         - |
| ToLevenshteinDistance         | .NET 9.0 | .NET 9.0 | ?                    |                      |    40.94 ns |  0.814 ns |  1.951 ns |      96 B |
| LevenshteinDistance           | .NET 9.0 | .NET 9.0 | ?                    | chara(...)s key [23] |    26.70 ns |  0.276 ns |  0.244 ns |         - |
| LevenshteinDistanceOperations | .NET 9.0 | .NET 9.0 | ?                    | chara(...)s key [23] |   391.55 ns |  7.869 ns | 14.779 ns |    1392 B |
| ToLevenshteinDistance         | .NET 9.0 | .NET 9.0 | ?                    | chara(...)s key [23] |   458.20 ns |  9.098 ns | 19.971 ns |    1696 B |
| LevenshteinDistance           | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] |                      |    40.45 ns |  0.481 ns |  0.426 ns |         - |
| LevenshteinDistanceOperations | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] |                      |   368.45 ns |  6.655 ns | 11.479 ns |    1328 B |
| ToLevenshteinDistance         | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] |                      |   448.50 ns |  8.871 ns | 16.662 ns |    1616 B |
| LevenshteinDistance           | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] | chara(...)s key [23] | 4,625.34 ns | 43.637 ns | 38.683 ns |         - |
| LevenshteinDistanceOperations | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] | chara(...)s key [23] | 5,099.23 ns | 55.333 ns | 49.051 ns |    1424 B |
| ToLevenshteinDistance         | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] | chara(...)s key [23] | 5,237.76 ns | 64.318 ns | 60.163 ns |    1736 B |



| Method                         | Job      | Runtime  | Src                  | Target               | Mean         | Error      | StdDev     | Median       | Allocated |
|------------------------------- |--------- |--------- |--------------------- |--------------------- |-------------:|-----------:|-----------:|-------------:|----------:|
| CalculateLevenshteinDistance   | .NET 8.0 | .NET 8.0 | ?                    |                      |     5.657 ns |  0.0405 ns |  0.0359 ns |     5.656 ns |         - |
| CalculateLevenshteinOperations | .NET 8.0 | .NET 8.0 | ?                    |                      |     4.809 ns |  0.0467 ns |  0.0390 ns |     4.808 ns |         - |
| ToLevenshteinDistanceModel     | .NET 8.0 | .NET 8.0 | ?                    |                      |    24.716 ns |  0.4589 ns |  0.4068 ns |    24.771 ns |      96 B |
| CalculateLevenshteinDistance   | .NET 9.0 | .NET 9.0 | ?                    |                      |     4.409 ns |  0.0193 ns |  0.0180 ns |     4.409 ns |         - |
| CalculateLevenshteinOperations | .NET 9.0 | .NET 9.0 | ?                    |                      |     4.479 ns |  0.0387 ns |  0.0343 ns |     4.486 ns |         - |
| ToLevenshteinDistanceModel     | .NET 9.0 | .NET 9.0 | ?                    |                      |    24.091 ns |  0.4537 ns |  0.6210 ns |    24.167 ns |      96 B |
| CalculateLevenshteinDistance   | .NET 8.0 | .NET 8.0 | ?                    | abc                  |    14.794 ns |  0.3033 ns |  0.2837 ns |    14.763 ns |         - |
| CalculateLevenshteinOperations | .NET 8.0 | .NET 8.0 | ?                    | abc                  |    79.573 ns |  1.6027 ns |  2.9307 ns |    79.452 ns |     232 B |
| ToLevenshteinDistanceModel     | .NET 8.0 | .NET 8.0 | ?                    | abc                  |   132.934 ns |  2.9276 ns |  8.6321 ns |   131.224 ns |     384 B |
| CalculateLevenshteinDistance   | .NET 9.0 | .NET 9.0 | ?                    | abc                  |    10.433 ns |  0.1517 ns |  0.1345 ns |    10.459 ns |         - |
| CalculateLevenshteinOperations | .NET 9.0 | .NET 9.0 | ?                    | abc                  |    94.210 ns |  1.6068 ns |  1.5781 ns |    94.002 ns |     232 B |
| ToLevenshteinDistanceModel     | .NET 9.0 | .NET 9.0 | ?                    | abc                  |   121.048 ns |  2.4592 ns |  5.6009 ns |   119.461 ns |     384 B |
| CalculateLevenshteinDistance   | .NET 8.0 | .NET 8.0 | ?                    | chara(...)s key [23] |    26.136 ns |  0.3061 ns |  0.2863 ns |    26.101 ns |         - |
| CalculateLevenshteinOperations | .NET 8.0 | .NET 8.0 | ?                    | chara(...)s key [23] |   425.834 ns |  8.2740 ns | 11.5990 ns |   427.798 ns |    1392 B |
| ToLevenshteinDistanceModel     | .NET 8.0 | .NET 8.0 | ?                    | chara(...)s key [23] |   488.106 ns |  9.7513 ns | 22.7934 ns |   489.685 ns |    1696 B |
| CalculateLevenshteinDistance   | .NET 9.0 | .NET 9.0 | ?                    | chara(...)s key [23] |    21.273 ns |  0.4183 ns |  0.3709 ns |    21.214 ns |         - |
| CalculateLevenshteinOperations | .NET 9.0 | .NET 9.0 | ?                    | chara(...)s key [23] |   429.230 ns |  8.6150 ns | 22.2380 ns |   428.004 ns |    1392 B |
| ToLevenshteinDistanceModel     | .NET 9.0 | .NET 9.0 | ?                    | chara(...)s key [23] |   459.072 ns |  8.8132 ns |  9.4300 ns |   459.957 ns |    1696 B |
| CalculateLevenshteinDistance   | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] |                      |     3.726 ns |  0.0259 ns |  0.0230 ns |     3.728 ns |         - |
| CalculateLevenshteinOperations | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] |                      |   513.651 ns | 10.2459 ns | 21.3871 ns |   510.172 ns |    1248 B |
| ToLevenshteinDistanceModel     | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] |                      |   525.119 ns | 10.4744 ns | 21.1588 ns |   524.352 ns |    1536 B |
| CalculateLevenshteinDistance   | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] |                      |     2.767 ns |  0.0258 ns |  0.0242 ns |     2.766 ns |         - |
| CalculateLevenshteinOperations | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] |                      |   435.172 ns |  7.9230 ns |  7.0236 ns |   435.155 ns |    1248 B |
| ToLevenshteinDistanceModel     | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] |                      |   535.017 ns | 10.5558 ns | 17.9246 ns |   535.575 ns |    1536 B |
| CalculateLevenshteinDistance   | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] | abc                  |   622.951 ns |  6.0273 ns |  5.6379 ns |   623.347 ns |         - |
| CalculateLevenshteinOperations | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] | abc                  | 1,081.860 ns | 14.0918 ns | 11.7673 ns | 1,085.873 ns |    1296 B |
| ToLevenshteinDistanceModel     | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] | abc                  | 1,070.146 ns | 21.3699 ns | 37.4277 ns | 1,066.687 ns |    1576 B |
| CalculateLevenshteinDistance   | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] | abc                  |   613.356 ns | 11.2214 ns | 10.4965 ns |   616.113 ns |         - |
| CalculateLevenshteinOperations | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] | abc                  | 1,008.618 ns | 19.5266 ns | 23.9804 ns | 1,002.494 ns |    1296 B |
| ToLevenshteinDistanceModel     | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] | abc                  | 1,040.571 ns | 20.6030 ns | 27.5044 ns | 1,044.193 ns |    1576 B |
| CalculateLevenshteinDistance   | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] | chara(...)s key [23] | 4,431.759 ns | 35.2834 ns | 33.0041 ns | 4,429.707 ns |         - |
| CalculateLevenshteinOperations | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] | chara(...)s key [23] | 4,804.758 ns | 50.1491 ns | 46.9095 ns | 4,801.122 ns |    1424 B |
| ToLevenshteinDistanceModel     | .NET 8.0 | .NET 8.0 | a bun(...)cters [21] | chara(...)s key [23] | 4,861.921 ns | 39.5187 ns | 36.9658 ns | 4,859.679 ns |    1736 B |
| CalculateLevenshteinDistance   | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] | chara(...)s key [23] | 4,395.675 ns | 37.3511 ns | 31.1899 ns | 4,402.562 ns |         - |
| CalculateLevenshteinOperations | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] | chara(...)s key [23] | 4,782.685 ns | 51.4713 ns | 48.1463 ns | 4,779.061 ns |    1424 B |
| ToLevenshteinDistanceModel     | .NET 9.0 | .NET 9.0 | a bun(...)cters [21] | chara(...)s key [23] | 4,723.621 ns | 51.8255 ns | 48.4776 ns | 4,729.432 ns |    1736 B |
| CalculateLevenshteinDistance   | .NET 8.0 | .NET 8.0 | abc                  |                      |     3.728 ns |  0.0255 ns |  0.0213 ns |     3.731 ns |         - |
| CalculateLevenshteinOperations | .NET 8.0 | .NET 8.0 | abc                  |                      |    98.112 ns |  1.8637 ns |  1.8304 ns |    98.703 ns |     296 B |
| ToLevenshteinDistanceModel     | .NET 8.0 | .NET 8.0 | abc                  |                      |   138.165 ns |  2.8046 ns |  5.4035 ns |   137.617 ns |     448 B |
| CalculateLevenshteinDistance   | .NET 9.0 | .NET 9.0 | abc                  |                      |     2.808 ns |  0.0289 ns |  0.0270 ns |     2.802 ns |         - |
| CalculateLevenshteinOperations | .NET 9.0 | .NET 9.0 | abc                  |                      |    94.803 ns |  1.9268 ns |  3.8480 ns |    94.665 ns |     296 B |
| ToLevenshteinDistanceModel     | .NET 9.0 | .NET 9.0 | abc                  |                      |   136.390 ns |  2.7621 ns |  4.6149 ns |   136.232 ns |     448 B |
| CalculateLevenshteinDistance   | .NET 8.0 | .NET 8.0 | abc                  | abc                  |     6.428 ns |  0.0849 ns |  0.0794 ns |     6.424 ns |         - |
| CalculateLevenshteinOperations | .NET 8.0 | .NET 8.0 | abc                  | abc                  |     6.395 ns |  0.1080 ns |  0.1010 ns |     6.394 ns |         - |
| ToLevenshteinDistanceModel     | .NET 8.0 | .NET 8.0 | abc                  | abc                  |    24.281 ns |  0.5117 ns |  1.3833 ns |    23.794 ns |      96 B |
| CalculateLevenshteinDistance   | .NET 9.0 | .NET 9.0 | abc                  | abc                  |     3.862 ns |  0.0501 ns |  0.0444 ns |     3.864 ns |         - |
| CalculateLevenshteinOperations | .NET 9.0 | .NET 9.0 | abc                  | abc                  |     4.089 ns |  0.0357 ns |  0.0316 ns |     4.093 ns |         - |
| ToLevenshteinDistanceModel     | .NET 9.0 | .NET 9.0 | abc                  | abc                  |    23.290 ns |  0.4466 ns |  0.5807 ns |    23.438 ns |      96 B |
| CalculateLevenshteinDistance   | .NET 8.0 | .NET 8.0 | abc                  | chara(...)s key [23] |   648.195 ns |  3.6937 ns |  3.4551 ns |   648.751 ns |         - |
| CalculateLevenshteinOperations | .NET 8.0 | .NET 8.0 | abc                  | chara(...)s key [23] | 1,083.767 ns | 21.3036 ns | 20.9230 ns | 1,081.896 ns |    1392 B |
| ToLevenshteinDistanceModel     | .NET 8.0 | .NET 8.0 | abc                  | chara(...)s key [23] | 1,133.098 ns | 22.1704 ns | 27.2272 ns | 1,136.138 ns |    1696 B |
| CalculateLevenshteinDistance   | .NET 9.0 | .NET 9.0 | abc                  | chara(...)s key [23] |   642.643 ns |  4.2631 ns |  3.9877 ns |   641.715 ns |         - |
| CalculateLevenshteinOperations | .NET 9.0 | .NET 9.0 | abc                  | chara(...)s key [23] | 1,034.714 ns | 19.9858 ns | 29.9138 ns | 1,038.535 ns |    1392 B |
| ToLevenshteinDistanceModel     | .NET 9.0 | .NET 9.0 | abc                  | chara(...)s key [23] | 1,069.794 ns | 21.3860 ns | 29.9802 ns | 1,059.640 ns |    1696 B |


Using class

| Method                         | Job      | Runtime  | Src | Target | Mean      | Error     | StdDev    | Allocated |
|------------------------------- |--------- |--------- |---- |------- |----------:|----------:|----------:|----------:|
| CalculateLevenshteinDistance   | .NET 8.0 | .NET 8.0 | ?   |        |  4.042 ns | 0.0629 ns | 0.0588 ns |         - |
| CalculateLevenshteinOperations | .NET 8.0 | .NET 8.0 | ?   |        |  3.886 ns | 0.0470 ns | 0.0440 ns |         - |
| ToLevenshteinDistanceModel     | .NET 8.0 | .NET 8.0 | ?   |        | 22.137 ns | 0.3246 ns | 0.2878 ns |      96 B |
| ToLevenshteinDistanceModelOut  | .NET 8.0 | .NET 8.0 | ?   |        | 23.626 ns | 0.2505 ns | 0.2092 ns |      96 B |
| CalculateLevenshteinDistance   | .NET 9.0 | .NET 9.0 | ?   |        |  3.379 ns | 0.0627 ns | 0.0586 ns |         - |
| CalculateLevenshteinOperations | .NET 9.0 | .NET 9.0 | ?   |        |  3.423 ns | 0.0665 ns | 0.0590 ns |         - |
| ToLevenshteinDistanceModel     | .NET 9.0 | .NET 9.0 | ?   |        | 21.097 ns | 0.4252 ns | 0.3978 ns |      96 B |
| ToLevenshteinDistanceModelOut  | .NET 9.0 | .NET 9.0 | ?   |        | 23.024 ns | 0.2362 ns | 0.2209 ns |      96 B |

Using struct

| Method                         | Job      | Runtime  | Src | Target | Mean      | Error     | StdDev    | Allocated |
|------------------------------- |--------- |--------- |---- |------- |----------:|----------:|----------:|----------:|
| CalculateLevenshteinDistance   | .NET 8.0 | .NET 8.0 | ?   |        |  4.151 ns | 0.0774 ns | 0.0724 ns |         - |
| CalculateLevenshteinOperations | .NET 8.0 | .NET 8.0 | ?   |        |  3.923 ns | 0.0528 ns | 0.0441 ns |         - |
| ToLevenshteinDistanceModel     | .NET 8.0 | .NET 8.0 | ?   |        | 20.257 ns | 0.2899 ns | 0.2421 ns |      56 B |
| ToLevenshteinDistanceModelOut  | .NET 8.0 | .NET 8.0 | ?   |        | 22.221 ns | 0.4641 ns | 0.6946 ns |      56 B |
| CalculateLevenshteinDistance   | .NET 9.0 | .NET 9.0 | ?   |        |  3.317 ns | 0.0507 ns | 0.0449 ns |         - |
| CalculateLevenshteinOperations | .NET 9.0 | .NET 9.0 | ?   |        |  3.349 ns | 0.0662 ns | 0.0619 ns |         - |
| ToLevenshteinDistanceModel     | .NET 9.0 | .NET 9.0 | ?   |        | 19.783 ns | 0.4024 ns | 0.3764 ns |      56 B |
| ToLevenshteinDistanceModelOut  | .NET 9.0 | .NET 9.0 | ?   |        | 19.242 ns | 0.3918 ns | 0.3665 ns |      56 B |